﻿using RotMG_Net_Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class ServerPlayerShootPacket : IncomingPacket
    {
        public byte BulletId;
        public int OwnerId;
        public int ContainerType;
        public WorldPosData StartingPos;
        public float Angle;
        public short Damage;

        public override PacketType GetPacketType() => PacketType.ServerPlayerShoot;

        public override void Read(PacketInput input)
        {
            BulletId = input.ReadByte();
            OwnerId = input.ReadInt32();
            ContainerType = input.ReadInt32();
            (StartingPos = new WorldPosData()).Read(input);
            Angle = input.ReadSingle();
            Damage = input.ReadInt16();
        }
    }
}
