﻿using RotMG_Net_Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class ShowEffectPacket : IncomingPacket
    {
        public byte EffectType;
        public int TargetObjectId;
        public WorldPosData Pos1;
        public WorldPosData Pos2;
        public int Color;
        public float Duration;

        public override PacketType GetPacketType() => PacketType.ShowEffect;

        public override void Read(PacketInput input)
        {
            EffectType = input.ReadByte();
            TargetObjectId = input.ReadInt32();
            Pos1.Read(input);
            Pos2.Read(input);
            Color = input.ReadInt32();
            Duration = input.ReadSingle();
        }
    }
}
