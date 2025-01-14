﻿namespace BinaryKits.ZplUtility.Elements
{
    public abstract class ZplDownload : ZplElementBase
    {
        /// <summary>
        /// DRAM, Memory Card, EPROM, Flash
        /// R, E, B, and A
        /// </summary>
        public char StorageDevice { get; set; }

        public ZplDownload(char storageDevice)
        {
            StorageDevice = storageDevice;
        }
    }
}
