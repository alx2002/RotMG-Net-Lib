﻿using RotMG_Net_Lib.Networking.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Models
{
    public class SlotObjectData
    {
        public int ObjectId;
        public byte SlotId;
        public int ObjectType;

        public void Read(PacketInput input)
        {
            ObjectId = input.ReadInt32();
            SlotId = input.ReadByte();
            ObjectType = input.ReadInt32();
        }

        public void Write(PacketOutput output)
        {
            output.Write(ObjectId);
            output.Write(SlotId);
            output.Write(ObjectType);
        }
    }
}
