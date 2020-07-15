using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Diagnostics;

public class MineStat {
    const ushort dataSize = 512;
    const ushort numFields = 6;
    const int defaultTimeout = 5;

    public string Address { get; set; }
    public ushort Port { get; set; }
    public int Timeout { get; set; }
    public string Motd { get; set; }
    public string Version { get; set; }
    public string CurrentPlayers { get; set; }
    public string MaximumPlayers { get; set; }
    public bool ServerUp { get; set; }
    public long Latency { get; set; }

    public MineStat(string address, ushort port, int timeout = defaultTimeout) {
        var rawServerData = new byte[dataSize];

        Address = address;
        Port = port;
        Timeout = timeout * 1000;

        try {
            var stopWatch = new Stopwatch();
            var tcpclient = new TcpClient();
            tcpclient.ReceiveTimeout = Timeout;
            stopWatch.Start();
            tcpclient.Connect(address, port);
            stopWatch.Stop();
            Latency = stopWatch.ElapsedMilliseconds;
            var stream = tcpclient.GetStream();
            var payload = new byte[] { 0xFE, 0x01 };
            stream.Write(payload, 0, payload.Length);
            stream.Read(rawServerData, 0, dataSize);
            tcpclient.Close();
        } catch(Exception) {
            ServerUp = false;
            return;
        }

        if(rawServerData == null || rawServerData.Length == 0) {
            ServerUp = false;
        } else {
            var serverData = Encoding.Unicode.GetString(rawServerData).Split("\u0000\u0000\u0000".ToCharArray());
            if(serverData != null && serverData.Length >= numFields) {
                ServerUp = true;
                Version = serverData[2];
                Motd = serverData[3];
                CurrentPlayers = serverData[4];
                MaximumPlayers = serverData[5];
            } else {
                ServerUp = false;
            }
        }
    }

    #region Obsolete

    [Obsolete]
    public string GetAddress() {
        return Address;
    }

    [Obsolete]
    public void SetAddress(string address) {
        Address = address;
    }

    [Obsolete]
    public ushort GetPort() {
        return Port;
    }

    [Obsolete]
    public void SetPort(ushort port) {
        Port = port;
    }

    [Obsolete]
    public string GetMotd() {
        return Motd;
    }

    [Obsolete]
    public void SetMotd(string motd) {
        Motd = motd;
    }

    [Obsolete]
    public string GetVersion() {
        return Version;
    }

    [Obsolete]
    public void SetVersion(string version) {
        Version = version;
    }

    [Obsolete]
    public string GetCurrentPlayers() {
        return CurrentPlayers;
    }

    [Obsolete]
    public void SetCurrentPlayers(string currentPlayers) {
        CurrentPlayers = currentPlayers;
    }

    [Obsolete]
    public string GetMaximumPlayers() {
        return MaximumPlayers;
    }

    [Obsolete]
    public void SetMaximumPlayers(string maximumPlayers) {
        MaximumPlayers = maximumPlayers;
    }

    [Obsolete]
    public long GetLatency() {
        return Latency;
    }

    [Obsolete]
    public void SetLatency(long latency) {
        Latency = latency;
    }

    [Obsolete]
    public bool IsServerUp() {
        return ServerUp;
    }
}