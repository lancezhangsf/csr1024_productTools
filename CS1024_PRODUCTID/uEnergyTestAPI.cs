// uEnergyTestAPI.cs : Declares the DLL functions for C#.
// Generated by E:\Jenkins\workspace\uEnergy_Tools_v3_1_X_RCY\common\hosttools\ue_tools_3_0_2\prodtest\scripts\extract_tt_api.pl from uEnergyTest.h;  at 20/07/17 - 17:45:04
// Copyright (c) 2004-2017 Qualcomm Technologies International, Ltd.
// All Rights Reserved.
// Qualcomm Technologies International, Ltd. Confidential and Proprietary.

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace uEnergyTestAPI
{
    public class uEnergyTest
    {
#if PocketPC || WindowsCE
        const CharSet charset = CharSet.Auto;
        const CallingConvention calling_convention = CallingConvention.Winapi;
#else
        const CharSet charset = CharSet.Ansi;
        const CallingConvention calling_convention = CallingConvention.StdCall;
#endif

        [DllImport("uEnergyTest.dll", EntryPoint="uetGetVersion",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetGetVersion(out byte major, out byte minor, out byte release, out byte build);

        [DllImport("uEnergyTest.dll", EntryPoint="uetGetVersionInfo",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetGetVersionInfo(out ushort major, out ushort minor, out ushort release, out ushort build);

        [DllImport("uEnergyTest.dll", EntryPoint="uetGetTransports",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetGetTransports(out ushort maxLen, StringBuilder ports, StringBuilder trans, out ushort count);
        [DllImport("uEnergyTest.dll", EntryPoint="uetGetTransports",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetGetTransports(out ushort maxLen, byte [] ports, byte [] trans, out ushort count);

        [DllImport("uEnergyTest.dll", EntryPoint="uetOpen",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetOpen(String connOpts, String csDbFile, out IntPtr handle);
        [DllImport("uEnergyTest.dll", EntryPoint="uetOpen",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetOpen(byte [] connOpts, byte [] csDbFile, out IntPtr handle);

        [DllImport("uEnergyTest.dll", EntryPoint="uetOpenSpiUnlock",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetOpenSpiUnlock(String connOpts, String csDbFile, String unlockKey, out IntPtr handle);
        [DllImport("uEnergyTest.dll", EntryPoint="uetOpenSpiUnlock",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetOpenSpiUnlock(byte [] connOpts, byte [] csDbFile, byte [] unlockKey, out IntPtr handle);

        [DllImport("uEnergyTest.dll", EntryPoint="uetClose",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetClose(IntPtr handle);

        [DllImport("uEnergyTest.dll", EntryPoint="uetReset",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetReset(IntPtr handle);

        [DllImport("uEnergyTest.dll", EntryPoint="uetGetLastError",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern IntPtr uetGetLastError(IntPtr handle);

        [DllImport("uEnergyTest.dll", EntryPoint="uetGetChipId",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetGetChipId(IntPtr handle, out ushort chipId);

        [DllImport("uEnergyTest.dll", EntryPoint="uetGetUciVersion",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetGetUciVersion(IntPtr handle, out ushort uciVersion);

        [DllImport("uEnergyTest.dll", EntryPoint="uetGetFwBuildId",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetGetFwBuildId(IntPtr handle, out ushort buildId);

        [DllImport("uEnergyTest.dll", EntryPoint="uetGetFwBuildInfo",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetGetFwBuildInfo(IntPtr handle, out ushort maxLen, StringBuilder buildInfo);
        [DllImport("uEnergyTest.dll", EntryPoint="uetGetFwBuildInfo",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetGetFwBuildInfo(IntPtr handle, out ushort maxLen, byte [] buildInfo);

        [DllImport("uEnergyTest.dll", EntryPoint="uetLoadPtFirmware",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetLoadPtFirmware(IntPtr handle, String filePath, byte useCsCache);
        [DllImport("uEnergyTest.dll", EntryPoint="uetLoadPtFirmware",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetLoadPtFirmware(IntPtr handle, byte [] filePath, byte useCsCache);

        [DllImport("uEnergyTest.dll", EntryPoint="uetGetPtFwBuildId",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetGetPtFwBuildId(IntPtr handle, String filePath, out ushort buildId);
        [DllImport("uEnergyTest.dll", EntryPoint="uetGetPtFwBuildId",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetGetPtFwBuildId(IntPtr handle, byte [] filePath, out ushort buildId);

        [DllImport("uEnergyTest.dll", EntryPoint="uetGetPtFwBuildInfo",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetGetPtFwBuildInfo(IntPtr handle, String filePath, out ushort maxLen, StringBuilder buildInfo);
        [DllImport("uEnergyTest.dll", EntryPoint="uetGetPtFwBuildInfo",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetGetPtFwBuildInfo(IntPtr handle, byte [] filePath, out ushort maxLen, byte [] buildInfo);

        [DllImport("uEnergyTest.dll", EntryPoint="uetGetPtFwCsVersion",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetGetPtFwCsVersion(IntPtr handle, String filePath, out ushort csVersion);
        [DllImport("uEnergyTest.dll", EntryPoint="uetGetPtFwCsVersion",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetGetPtFwCsVersion(IntPtr handle, byte [] filePath, out ushort csVersion);

        [DllImport("uEnergyTest.dll", EntryPoint="uetGetPtFwApiVersion",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetGetPtFwApiVersion(IntPtr handle, out uint version);

        [DllImport("uEnergyTest.dll", EntryPoint="uetRadCwStart",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetRadCwStart(IntPtr handle, byte channel, ushort freqMhz);

        [DllImport("uEnergyTest.dll", EntryPoint="uetRadSetXtalTrim",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetRadSetXtalTrim(IntPtr handle, ushort value);

        [DllImport("uEnergyTest.dll", EntryPoint="uetRadCalcXtalOffset",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetRadCalcXtalOffset(IntPtr handle, double nominalFreqMhz, double actualFreqMhz, out short offsetPpm);

        [DllImport("uEnergyTest.dll", EntryPoint="uetRadStop",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetRadStop(IntPtr handle);

        [DllImport("uEnergyTest.dll", EntryPoint="uetRadTxStart",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetRadTxStart(IntPtr handle, byte channel, byte txLength, byte payload, ushort numPackets);

        [DllImport("uEnergyTest.dll", EntryPoint="uetRadTxSetPowerLevel",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetRadTxSetPowerLevel(IntPtr handle, byte powerLevel);

        [DllImport("uEnergyTest.dll", EntryPoint="uetRadTxGetPkts",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetRadTxGetPkts(IntPtr handle, out ushort numPackets);

        [DllImport("uEnergyTest.dll", EntryPoint="uetRadRxStart",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetRadRxStart(IntPtr handle, byte channel);

        [DllImport("uEnergyTest.dll", EntryPoint="uetRadRxGetPkts",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetRadRxGetPkts(IntPtr handle, out ushort numPackets);

        [DllImport("uEnergyTest.dll", EntryPoint="uetRadRxGetResults",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetRadRxGetResults(IntPtr handle, out ushort numPackets, out short rssiAverage, out int reserved);

        [DllImport("uEnergyTest.dll", EntryPoint="uetPioAssign",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetPioAssign(IntPtr handle, uint mask, uint direction);

        [DllImport("uEnergyTest.dll", EntryPoint="uetPioAssign64",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetPioAssign64(IntPtr handle, ulong mask, ulong direction);

        [DllImport("uEnergyTest.dll", EntryPoint="uetPioGet",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetPioGet(IntPtr handle, out uint direction, out uint state);

        [DllImport("uEnergyTest.dll", EntryPoint="uetPioGet64",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetPioGet64(IntPtr handle, out ulong reserved, out ulong state);

        [DllImport("uEnergyTest.dll", EntryPoint="uetPioSet",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetPioSet(IntPtr handle, uint outputMask, uint state);

        [DllImport("uEnergyTest.dll", EntryPoint="uetPioSet64",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetPioSet64(IntPtr handle, ulong outputMask, ulong state);

        [DllImport("uEnergyTest.dll", EntryPoint="uetAioGet",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetAioGet(IntPtr handle, byte aio, out ushort voltageMv);

        [DllImport("uEnergyTest.dll", EntryPoint="uetAioSet",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetAioSet(IntPtr handle, byte aio, ushort voltageMv);

        [DllImport("uEnergyTest.dll", EntryPoint="uetLedSet",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetLedSet(IntPtr handle, uint mask, byte mode, ushort intervalMs, byte brightness);

        [DllImport("uEnergyTest.dll", EntryPoint="uetLedSetSingle",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetLedSetSingle(IntPtr handle, byte pio, byte mode, ushort intervalMs, ushort reserved);

        [DllImport("uEnergyTest.dll", EntryPoint="uetUartLbTest",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetUartLbTest(IntPtr handle, String portName, uint baudRate);
        [DllImport("uEnergyTest.dll", EntryPoint="uetUartLbTest",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetUartLbTest(IntPtr handle, byte [] portName, uint baudRate);

        [DllImport("uEnergyTest.dll", EntryPoint="uetUartLbConfigurableTest",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetUartLbConfigurableTest(IntPtr handle, String portName, uint baudRate, byte txPio, byte rxPio, byte reserved1, byte reserved2, ushort reserved3);
        [DllImport("uEnergyTest.dll", EntryPoint="uetUartLbConfigurableTest",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetUartLbConfigurableTest(IntPtr handle, byte [] portName, uint baudRate, byte txPio, byte rxPio, byte reserved1, byte reserved2, ushort reserved3);

        [DllImport("uEnergyTest.dll", EntryPoint="uetCsReadItem",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetCsReadItem(IntPtr handle, String id, ushort [] value, out ushort length);
        [DllImport("uEnergyTest.dll", EntryPoint="uetCsReadItem",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetCsReadItem(IntPtr handle, byte [] id, ushort [] value, out ushort length);

        [DllImport("uEnergyTest.dll", EntryPoint="uetCsWriteItem",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetCsWriteItem(IntPtr handle, String id, ushort [] value, out ushort length);
        [DllImport("uEnergyTest.dll", EntryPoint="uetCsWriteItem",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetCsWriteItem(IntPtr handle, byte [] id, ushort [] value, out ushort length);

        [DllImport("uEnergyTest.dll", EntryPoint="uetCsWriteChipFromFile",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetCsWriteChipFromFile(IntPtr handle, String csFile);
        [DllImport("uEnergyTest.dll", EntryPoint="uetCsWriteChipFromFile",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetCsWriteChipFromFile(IntPtr handle, byte [] csFile);

        [DllImport("uEnergyTest.dll", EntryPoint="uetCsWriteFileFromChip",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetCsWriteFileFromChip(IntPtr handle, String csFile);
        [DllImport("uEnergyTest.dll", EntryPoint="uetCsWriteFileFromChip",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetCsWriteFileFromChip(IntPtr handle, byte [] csFile);

        [DllImport("uEnergyTest.dll", EntryPoint="uetCsFileMerge",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetCsFileMerge(IntPtr handle, String file);
        [DllImport("uEnergyTest.dll", EntryPoint="uetCsFileMerge",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetCsFileMerge(IntPtr handle, byte [] file);

        [DllImport("uEnergyTest.dll", EntryPoint="uetCsCacheReadItem",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetCsCacheReadItem(IntPtr handle, String name, ushort [] value, out ushort length);
        [DllImport("uEnergyTest.dll", EntryPoint="uetCsCacheReadItem",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetCsCacheReadItem(IntPtr handle, byte [] name, ushort [] value, out ushort length);

        [DllImport("uEnergyTest.dll", EntryPoint="uetCsCacheWriteItem",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetCsCacheWriteItem(IntPtr handle, String name, ushort [] value, out ushort length);
        [DllImport("uEnergyTest.dll", EntryPoint="uetCsCacheWriteItem",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetCsCacheWriteItem(IntPtr handle, byte [] name, ushort [] value, out ushort length);

        [DllImport("uEnergyTest.dll", EntryPoint="uetCsCacheReadFromChip",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetCsCacheReadFromChip(IntPtr handle, byte aType, byte csOnly);

        [DllImport("uEnergyTest.dll", EntryPoint="uetCsCacheWriteToChip",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetCsCacheWriteToChip(IntPtr handle, byte aType, byte csOnly);

        [DllImport("uEnergyTest.dll", EntryPoint="uetCsCacheReadFromFile",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetCsCacheReadFromFile(IntPtr handle, String file);
        [DllImport("uEnergyTest.dll", EntryPoint="uetCsCacheReadFromFile",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetCsCacheReadFromFile(IntPtr handle, byte [] file);

        [DllImport("uEnergyTest.dll", EntryPoint="uetCsCacheWriteToFile",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetCsCacheWriteToFile(IntPtr handle, String file);
        [DllImport("uEnergyTest.dll", EntryPoint="uetCsCacheWriteToFile",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetCsCacheWriteToFile(IntPtr handle, byte [] file);

        [DllImport("uEnergyTest.dll", EntryPoint="uetCsCacheFileMerge",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetCsCacheFileMerge(IntPtr handle, String sourceFile, byte mergeType);
        [DllImport("uEnergyTest.dll", EntryPoint="uetCsCacheFileMerge",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetCsCacheFileMerge(IntPtr handle, byte [] sourceFile, byte mergeType);

        [DllImport("uEnergyTest.dll", EntryPoint="uetCsCacheOtauApp",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetCsCacheOtauApp(IntPtr handle, ushort qtilOtauVersion, uint appOffset);

        [DllImport("uEnergyTest.dll", EntryPoint="uetCsCacheGetVersion",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetCsCacheGetVersion(IntPtr handle, out ushort csVersion);

        [DllImport("uEnergyTest.dll", EntryPoint="uetNvmCustomRead",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetNvmCustomRead(IntPtr handle, byte aType, ushort offset, out ushort data, ushort length);

        [DllImport("uEnergyTest.dll", EntryPoint="uetNvmCustomWrite",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetNvmCustomWrite(IntPtr handle, byte aType, ushort offset, ref ushort data, ushort length);

        [DllImport("uEnergyTest.dll", EntryPoint="uetNvmUnlock",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetNvmUnlock(IntPtr handle, byte aType, uint startAddress, uint endAddress);

        [DllImport("uEnergyTest.dll", EntryPoint="uetNvmRead",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetNvmRead(IntPtr handle, byte aType, uint address, out ushort data, ushort length);

        [DllImport("uEnergyTest.dll", EntryPoint="uetNvmWrite",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetNvmWrite(IntPtr handle, byte aType, uint address, ref ushort data, ushort length);

        [DllImport("uEnergyTest.dll", EntryPoint="uetNvmSetSFlashPios",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetNvmSetSFlashPios(IntPtr handle, byte pioSclk, byte pioMiso, byte reserved);

        [DllImport("uEnergyTest.dll", EntryPoint="uetSecureStoreWrite",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetSecureStoreWrite(IntPtr handle, String spiKeysFile, String decryptKeysFile, byte sotre_lock);
        [DllImport("uEnergyTest.dll", EntryPoint="uetSecureStoreWrite",
                CharSet=charset, CallingConvention=calling_convention)]
        public static extern int uetSecureStoreWrite(IntPtr handle, byte [] spiKeysFile, byte [] decryptKeysFile, byte store_lock);

    }
}
