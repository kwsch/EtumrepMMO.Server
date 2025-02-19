﻿using System.Net.Security;
using System.Net.Sockets;

namespace EtumrepMMO.Server;

internal class RemoteUser
{
    public override string ToString() => $"{EntryID}. {UserAuth}";

    internal RemoteUser(TcpClient client, AuthenticatedStream stream)
    {
        Client = client;
        Stream = stream;
    }

    public TcpClient Client { get; }
    public AuthenticatedStream Stream { get; }
    public UserAuth UserAuth { get; set; } = new();
    public byte[] Buffer { get; } = new byte[EtumrepUtil.MAXCOUNT * EtumrepUtil.SIZE];

    public bool IsAuthenticated { get; set; }
    public int EntryID { get; set; }
}
