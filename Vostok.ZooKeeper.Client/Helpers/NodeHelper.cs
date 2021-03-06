﻿using System;

namespace Vostok.ZooKeeper.Client.Helpers
{
    internal static class NodeHelper
    {
        // Note(kungurtsev): 1024 * 1024 bytes leads to connection loss.
        public const int DataSizeLimit = 1024 * 1023;

        public static Exception DataSizeLimitExceededException(byte[] data) => new ArgumentException($"Data size limit exceeded: {data?.Length} bytes, but only {DataSizeLimit} bytes allowed.");

        public static bool ValidateDataSize(byte[] data)
        {
            return data == null || data.Length <= DataSizeLimit;
        }
    }
}