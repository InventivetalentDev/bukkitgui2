﻿// Wmi.cs in bukkitgui2/bukkitgui2
// Created 2014/05/04
// 
// This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
// If a copy of the MPL was not distributed with this file,
// you can obtain one at http://mozilla.org/MPL/2.0/.
// 
// ©Bertware, visit http://bertware.net

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net;
using Net.Bertware.Bukkitgui2.Core.Logging;
// ReSharper disable InconsistentNaming

namespace Net.Bertware.Bukkitgui2.Core.Util.Performance
{
    public static class Wmi
    {
        public enum Classlist
        {
            Win32_1394Controller,
            Win32_1394ControllerDevice,
            Win32_Account,
            Win32_AccountSID,
            Win32_ACE,
            Win32_ActionCheck,
            Win32_AllocatedResource,
            Win32_ApplicationCommandLine,
            Win32_ApplicationService,
            Win32_AssociatedBattery,
            Win32_AssociatedProcessorMemory,
            Win32_BaseBoard,
            Win32_BaseService,
            Win32_Battery,
            Win32_Binary,
            Win32_BindImageAction,
            Win32_BIOS,
            Win32_BootConfiguration,
            Win32_Bus,
            Win32_CacheMemory,
            Win32_CDROMDrive,
            Win32_CheckCheck,
            Win32_CIMLogicalDeviceCIMDataFile,
            Win32_ClassicCOMApplicationClasses,
            Win32_ClassicCOMClass,
            Win32_ClassicCOMClassSetting,
            Win32_ClassicCOMClassSettings,
            Win32_ClassInfoAction,
            Win32_ClientApplicationSetting,
            Win32_CodecFile,
            Win32_COMApplication,
            Win32_COMApplicationClasses,
            Win32_COMApplicationSettings,
            Win32_COMClass,
            Win32_ComClassAutoEmulator,
            Win32_ComClassEmulator,
            Win32_CommandLineAccess,
            Win32_ComponentCategory,
            Win32_ComputerSystem,
            Win32_ComputerSystemProcessor,
            Win32_ComputerSystemProduct,
            Win32_COMSetting,
            Win32_Condition,
            Win32_CreateFolderAction,
            Win32_CurrentProbe,
            Win32_DCOMApplication,
            Win32_DCOMApplicationAccessAllowedSetting,
            Win32_DCOMApplicationLaunchAllowedSetting,
            Win32_DCOMApplicationSetting,
            Win32_DependentService,
            Win32_Desktop,
            Win32_DesktopMonitor,
            Win32_DeviceBus,
            Win32_DeviceMemoryAddress,
            Win32_DeviceSettings,
            Win32_Directory,
            Win32_DirectorySpecification,
            Win32_DiskDrive,
            Win32_DiskDriveToDiskPartition,
            Win32_DiskPartition,
            Win32_DisplayConfiguration,
            Win32_DisplayControllerConfiguration,
            Win32_DMAChannel,
            Win32_DriverVXD,
            Win32_DuplicateFileAction,
            Win32_Environment,
            Win32_EnvironmentSpecification,
            Win32_ExtensionInfoAction,
            Win32_Fan,
            Win32_FileSpecification,
            Win32_FloppyController,
            Win32_FloppyDrive,
            Win32_FontInfoAction,
            Win32_Group,
            Win32_GroupUser,
            Win32_HeatPipe,
            Win32_IDEController,
            Win32_IDEControllerDevice,
            Win32_ImplementedCategory,
            Win32_InfraredDevice,
            Win32_IniFileSpecification,
            Win32_InstalledSoftwareElement,
            Win32_IRQResource,
            Win32_Keyboard,
            Win32_LaunchCondition,
            Win32_LoadOrderGroup,
            Win32_LoadOrderGroupServiceDependencies,
            Win32_LoadOrderGroupServiceMembers,
            Win32_LogicalDisk,
            Win32_LogicalDiskRootDirectory,
            Win32_LogicalDiskToPartition,
            Win32_LogicalFileAccess,
            Win32_LogicalFileAuditing,
            Win32_LogicalFileGroup,
            Win32_LogicalFileOwner,
            Win32_LogicalFileSecuritySetting,
            Win32_LogicalMemoryConfiguration,
            Win32_LogicalProgramGroup,
            Win32_LogicalProgramGroupDirectory,
            Win32_LogicalProgramGroupItem,
            Win32_LogicalProgramGroupItemDataFile,
            Win32_LogicalShareAccess,
            Win32_LogicalShareAuditing,
            Win32_LogicalShareSecuritySetting,
            Win32_ManagedSystemElementResource,
            Win32_MemoryArray,
            Win32_MemoryArrayLocation,
            Win32_MemoryDevice,
            Win32_MemoryDeviceArray,
            Win32_MemoryDeviceLocation,
            Win32_MethodParameterClass,
            Win32_MIMEInfoAction,
            Win32_MotherboardDevice,
            Win32_MoveFileAction,
            Win32_MSIResource,
            Win32_NetworkAdapter,
            Win32_NetworkAdapterConfiguration,
            Win32_NetworkAdapterSetting,
            Win32_NetworkClient,
            Win32_NetworkConnection,
            Win32_NetworkLoginProfile,
            Win32_NetworkProtocol,
            Win32_NTEventlogFile,
            Win32_NTLogEvent,
            Win32_NTLogEventComputer,
            Win32_NTLogEventLog,
            Win32_NTLogEventUser,
            Win32_ODBCAttribute,
            Win32_ODBCDataSourceAttribute,
            Win32_ODBCDataSourceSpecification,
            Win32_ODBCDriverAttribute,
            Win32_ODBCDriverSoftwareElement,
            Win32_ODBCDriverSpecification,
            Win32_ODBCSourceAttribute,
            Win32_ODBCTranslatorSpecification,
            Win32_OnBoardDevice,
            Win32_OperatingSystem,
            Win32_OperatingSystemQFE,
            Win32_OSRecoveryConfiguration,
            Win32_PageFile,
            Win32_PageFileElementSetting,
            Win32_PageFileSetting,
            Win32_PageFileUsage,
            Win32_ParallelPort,
            Win32_Patch,
            Win32_PatchFile,
            Win32_PatchPackage,
            Win32_PCMCIAController,
            Win32_Perf,
            Win32_PerfRawData,
            Win32_PerfRawData_ASP_ActiveServerPages,
            Win32_PerfRawData_ASPNET_114322_ASPNETAppsv114322,
            Win32_PerfRawData_ASPNET_114322_ASPNETv114322,
            Win32_PerfRawData_ASPNET_ASPNET,
            Win32_PerfRawData_ASPNET_ASPNETApplications,
            Win32_PerfRawData_IAS_IASAccountingClients,
            Win32_PerfRawData_IAS_IASAccountingServer,
            Win32_PerfRawData_IAS_IASAuthenticationClients,
            Win32_PerfRawData_IAS_IASAuthenticationServer,
            Win32_PerfRawData_InetInfo_InternetInformationServicesGlobal,
            Win32_PerfRawData_MSDTC_DistributedTransactionCoordinator,
            Win32_PerfRawData_MSFTPSVC_FTPService,
            Win32_PerfRawData_MSSQLSERVER_SQLServerAccessMethods,
            Win32_PerfRawData_MSSQLSERVER_SQLServerBackupDevice,
            Win32_PerfRawData_MSSQLSERVER_SQLServerBufferManager,
            Win32_PerfRawData_MSSQLSERVER_SQLServerBufferPartition,
            Win32_PerfRawData_MSSQLSERVER_SQLServerCacheManager,
            Win32_PerfRawData_MSSQLSERVER_SQLServerDatabases,
            Win32_PerfRawData_MSSQLSERVER_SQLServerGeneralStatistics,
            Win32_PerfRawData_MSSQLSERVER_SQLServerLatches,
            Win32_PerfRawData_MSSQLSERVER_SQLServerLocks,
            Win32_PerfRawData_MSSQLSERVER_SQLServerMemoryManager,
            Win32_PerfRawData_MSSQLSERVER_SQLServerReplicationAgents,
            Win32_PerfRawData_MSSQLSERVER_SQLServerReplicationDist,
            Win32_PerfRawData_MSSQLSERVER_SQLServerReplicationLogreader,
            Win32_PerfRawData_MSSQLSERVER_SQLServerReplicationMerge,
            Win32_PerfRawData_MSSQLSERVER_SQLServerReplicationSnapshot,
            Win32_PerfRawData_MSSQLSERVER_SQLServerSQLStatistics,
            Win32_PerfRawData_MSSQLSERVER_SQLServerUserSettable,
            Win32_PerfRawData_NETFramework_NETCLRExceptions,
            Win32_PerfRawData_NETFramework_NETCLRInterop,
            Win32_PerfRawData_NETFramework_NETCLRJit,
            Win32_PerfRawData_NETFramework_NETCLRLoading,
            Win32_PerfRawData_NETFramework_NETCLRLocksAndThreads,
            Win32_PerfRawData_NETFramework_NETCLRMemory,
            Win32_PerfRawData_NETFramework_NETCLRRemoting,
            Win32_PerfRawData_NETFramework_NETCLRSecurity,
            Win32_PerfRawData_Outlook_Outlook,
            Win32_PerfRawData_PerfDisk_PhysicalDisk,
            Win32_PerfRawData_PerfNet_Browser,
            Win32_PerfRawData_PerfNet_Redirector,
            Win32_PerfRawData_PerfNet_Server,
            Win32_PerfRawData_PerfNet_ServerWorkQueues,
            Win32_PerfRawData_PerfOS_Cache,
            Win32_PerfRawData_PerfOS_Memory,
            Win32_PerfRawData_PerfOS_Objects,
            Win32_PerfRawData_PerfOS_PagingFile,
            Win32_PerfRawData_PerfOS_Processor,
            Win32_PerfRawData_PerfOS_System,
            Win32_PerfRawData_PerfProc_FullImage_Costly,
            Win32_PerfRawData_PerfProc_Image_Costly,
            Win32_PerfRawData_PerfProc_JobObject,
            Win32_PerfRawData_PerfProc_JobObjectDetails,
            Win32_PerfRawData_PerfProc_Process,
            Win32_PerfRawData_PerfProc_ProcessAddressSpace_Costly,
            Win32_PerfRawData_PerfProc_Thread,
            Win32_PerfRawData_PerfProc_ThreadDetails_Costly,
            Win32_PerfRawData_RemoteAccess_RASPort,
            Win32_PerfRawData_RemoteAccess_RASTotal,
            Win32_PerfRawData_RSVP_ACSPerRSVPService,
            Win32_PerfRawData_Spooler_PrintQueue,
            Win32_PerfRawData_TapiSrv_Telephony,
            Win32_PerfRawData_Tcpip_ICMP,
            Win32_PerfRawData_Tcpip_IP,
            Win32_PerfRawData_Tcpip_NBTConnection,
            Win32_PerfRawData_Tcpip_NetworkInterface,
            Win32_PerfRawData_Tcpip_TCP,
            Win32_PerfRawData_Tcpip_UDP,
            Win32_PerfRawData_W3SVC_WebService,
            Win32_PhysicalMemory,
            Win32_PhysicalMemoryArray,
            Win32_PhysicalMemoryLocation,
            Win32_PNPAllocatedResource,
            Win32_PnPDevice,
            Win32_PnPEntity,
            Win32_PointingDevice,
            Win32_PortableBattery,
            Win32_PortConnector,
            Win32_PortResource,
            Win32_POTSModem,
            Win32_POTSModemToSerialPort,
            Win32_PowerManagementEvent,
            Win32_Printer,
            Win32_PrinterConfiguration,
            Win32_PrinterController,
            Win32_PrinterDriverDll,
            Win32_PrinterSetting,
            Win32_PrinterShare,
            Win32_PrintJob,
            Win32_PrivilegesStatus,
            Win32_Process,
            Win32_Processor,
            Win32_ProcessStartup,
            Win32_Product,
            Win32_ProductCheck,
            Win32_ProductResource,
            Win32_ProductSoftwareFeatures,
            Win32_ProgIDSpecification,
            Win32_ProgramGroup,
            Win32_ProgramGroupContents,
            Win32_ProgramGroupOrItem,
            Win32_Prop,
            Win32_ProtocolBinding,
            Win32_PublishComponentAction,
            Win32_QuickFixEngineering,
            Win32_Refrigeration,
            Win32_Registry,
            Win32_RegistryAction,
            Win32_RemoveFileAction,
            Win32_RemoveIniAction,
            Win32_ReserveCost,
            Win32_ScheduledJob,
            Win32_SCSIController,
            Win32_SCSIControllerDevice,
            Win32_SecurityDescriptor,
            Win32_SecuritySetting,
            Win32_SecuritySettingAccess,
            Win32_SecuritySettingAuditing,
            Win32_SecuritySettingGroup,
            Win32_SecuritySettingOfLogicalFile,
            Win32_SecuritySettingOfLogicalShare,
            Win32_SecuritySettingOfObject,
            Win32_SecuritySettingOwner,
            Win32_SelfRegModuleAction,
            Win32_SerialPort,
            Win32_SerialPortConfiguration,
            Win32_SerialPortSetting,
            Win32_Service,
            Win32_ServiceControl,
            Win32_ServiceSpecification,
            Win32_ServiceSpecificationService,
            Win32_SettingCheck,
            Win32_Share,
            Win32_ShareToDirectory,
            Win32_ShortcutAction,
            Win32_ShortcutFile,
            Win32_ShortcutSAP,
            Win32_SID,
            Win32_SMBIOSMemory,
            Win32_SoftwareElement,
            Win32_SoftwareElementAction,
            Win32_SoftwareElementCheck,
            Win32_SoftwareElementCondition,
            Win32_SoftwareElementResource,
            Win32_SoftwareFeature,
            Win32_SoftwareFeatureAction,
            Win32_SoftwareFeatureCheck,
            Win32_SoftwareFeatureParent,
            Win32_SoftwareFeatureSoftwareElements,
            Win32_SoundDevice,
            Win32_StartupCommand,
            Win32_SubDirectory,
            Win32_SystemAccount,
            Win32_SystemBIOS,
            Win32_SystemBootConfiguration,
            Win32_SystemDesktop,
            Win32_SystemDevices,
            Win32_SystemDriver,
            Win32_SystemDriverPNPEntity,
            Win32_SystemEnclosure,
            Win32_SystemLoadOrderGroups,
            Win32_SystemLogicalMemoryConfiguration,
            Win32_SystemMemoryResource,
            Win32_SystemNetworkConnections,
            Win32_SystemOperatingSystem,
            Win32_SystemPartitions,
            Win32_SystemProcesses,
            Win32_SystemProgramGroups,
            Win32_SystemResources,
            Win32_SystemServices,
            Win32_SystemSetting,
            Win32_SystemSlot,
            Win32_SystemSystemDriver,
            Win32_SystemTimeZone,
            Win32_SystemUsers,
            Win32_TapeDrive,
            Win32_TemperatureProbe,
            Win32_Thread,
            Win32_TimeZone,
            Win32_Trustee,
            Win32_TypeLibraryAction,
            Win32_UninterruptiblePowerSupply,
            Win32_USBController,
            Win32_USBControllerDevice,
            Win32_UserAccount,
            Win32_UserDesktop,
            Win32_VideoConfiguration,
            Win32_VideoController,
            Win32_VideoSettings,
            Win32_VoltageProbe,
            Win32_WMIElementSetting,
            Win32_WMISetting
        }

        //general object, can be used for classes that aren't specified below

        public static string GetobjectInfo(string @class, string Property, string SelectProp, string value)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + Property + " From " + @class + " Where " + SelectProp + " = '" +
                                             value +
                                             "'");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[Property].ToString();
            }
            return result;
        }

        public static string GetobjectInfo(Classlist @class, string Property, string name)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + Property + " From " + @class + " Where Name = '" + name + "'");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[Property].ToString();
            }
            return result;
        }

        public static string GetobjectInfo(string @class, string Property, string name)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + Property + " From " + @class + " Where Name = '" + name + "'");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            String result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[Property].ToString();
            }
            return result;
        }

        public static string GetobjectInfo(Classlist @class, string Property)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + Property + " From " + @class);
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[Property].ToString();
            }
            return result;
        }

        public static string GetobjectInfo(string @class, string Prop)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + Prop + " From " + @class);
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[Prop].ToString();
            }
            return result;
        }

        //processor
        public enum ProcessorProp
        {
            AddressWidth,
            Architecture,
            Availability,
            Caption,
            ConfigManagerErrorCode,
            ConfigManagerUserConfig,
            CpuStatus,
            CreationClassName,
            CurrentClockSpeed,
            CurrentVoltage,
            DataWidth,
            Description,
            DeviceID,
            ErrorCleared,
            ErrorDescription,
            ExtClock,
            Family,
            InstallDate,
            L2CacheSize,
            L2CacheSpeed,
            L3CacheSize,
            L3CacheSpeed,
            LastErrorCode,
            Level,
            LoadPercentage,
            Manufacturer,
            MaxClockSpeed,
            Name,
            NumberOfCores,
            NumberOfLogicalProcessors,
            OtherFamilyDescription,
            PNPDeviceID,
            PowerManagementSupported,
            ProcessorId,
            ProcessorType,
            Revision,
            Role,
            SocketDesignation,
            Status,
            StatusInfo,
            Stepping,
            SystemCreationClassName,
            SystemName,
            UniqueId,
            UpgradeMethod,
            Version,
            VoltageCaps
        }

        public static string GetprocessorInfo(ProcessorProp type, string name)
        {
            try
            {
                ManagementObjectSearcher managementObjectSearcher =
                    new ManagementObjectSearcher("Select " + type + " from Win32_Processor Where Name = '" + name + "'");
                ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
                string result = null;
                foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
                {
                    result = managementObject[type.ToString()].ToString();
                }
                return result;
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Warning, "Wmi", "WMI access failed!", ex.Message);
                return null;
            }
        }

        public static string GetprocessorInfo(ProcessorProp type)
        {
            try
            {
                ManagementObjectSearcher managementObjectSearcher =
                    new ManagementObjectSearcher("Select " + type + " From Win32_Processor");
                ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
                string result = null;
                foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
                {
                    result = managementObject[type.ToString()].ToString();
                }
                return result;
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Warning, "Wmi", "WMI access failed!", ex.Message);
                return null;
            }
        }

        //process
        public enum ProcessProp
        {
            Caption,
            CommandLine,
            CreationClassName,
            CreationDate,
            CSCreationClassName,
            CSName,
            Description,
            ExecutablePath,
            ExecutionState,
            Handle,
            HandleCount,
            InstallDate,
            KernelModeTime,
            MaximumWorkingSetSize,
            MinimumWorkingSetSize,
            Name,
            OSCreationClassName,
            OSName,
            OtherOperationCount,
            OtherTransferCount,
            PageFaults,
            PageFileUsage,
            ParentProcessId,
            PeakPageFileUsage,
            PeakVirtualSize,
            PeakWorkingSetSize,
            Priority,
            publicPageCount,
            ProcessId,
            QuotaNonPagedPoolUsage,
            QuotaPagedPoolUsage,
            QuotaPeakNonPagedPoolUsage,
            QuotaPeakPagedPoolUsage,
            ReadOperationCount,
            ReadTransferCount,
            SessionId,
            Status,
            TerminationDate,
            ThreadCount,
            UserModeTime,
            VirtualSize,
            WindowsVersion,
            WorkingSetSize,
            WriteOperationCount,
            WriteTransferCount
        }

        public static string GetprocessInfo(ProcessProp type, string name)
        {
            try
            {
                ManagementObjectSearcher managementObjectSearcher =
                    new ManagementObjectSearcher("Select " + type + " from Win32_Process Where Name = '" + name + "'");
                ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
                string result = null;
                foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
                {
                    result = managementObject[type.ToString()].ToString();
                }
                return result;
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Warning, "Wmi", "WMI access failed!", ex.Message);
                return null;
            }
        }

        public static string GetprocessInfo(ProcessProp type, int id)
        {
            try
            {
                ManagementObjectSearcher managementObjectSearcher =
                    new ManagementObjectSearcher("Select " + type + " from Win32_Process Where ProcessId = '" + id + "'");
                ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
                string result = null;
                foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
                {
                    result = managementObject[type.ToString()].ToString();
                }
                return result;
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Warning, "Wmi", "WMI access failed!", ex.Message);
                return null;
            }
        }

        public static string GetprocessInfo(ProcessProp type)
        {
            try
            {
                ManagementObjectSearcher managementObjectSearcher =
                    new ManagementObjectSearcher("Select " + type + " From Win32_Process");
                ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
                string result = null;
                foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
                {
                    result = managementObject[type.ToString()].ToString();
                }
                return result;
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Warning, "Wmi", "WMI access failed!", ex.Message);
                return null;
            }
        }

        //motherboard
        public enum MotherboardProp
        {
            Availability,
            Caption,
            ConfigManagerErrorCode,
            ConfigManagerUserConfig,
            CreationClassName,
            Description,
            DeviceID,
            ErrorCleared,
            ErrorDescription,
            InstallDate,
            LastErrorCode,
            Name,
            PNPDeviceID,
            PowerManagementSupported,
            PrimaryBusType,
            RevisionNumber,
            SecondaryBusType,
            Status,
            StatusInfo,
            SystemCreationClassName,
            SystemName
        }

        public static string GetMotherBoardInfo(MotherboardProp type, string name)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type + " from Win32_MotherBoardDevice Where Name = '" + name +
                                             "'");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[type.ToString()].ToString();
            }
            return result;
        }

        public static string GetMotherBoardInfo(MotherboardProp type)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type + " From Win32_MotherBoardDevice");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[type.ToString()].ToString();
            }
            return result;
        }

        //fan
        public enum fanProp
        {
            ActiveCooling,
            Availability,
            Caption,
            ConfigManagerErrorCode,
            ConfigManagerUserConfig,
            CreationClassName,
            Description,
            DesiredSpeed,
            DeviceID,
            ErrorCleared,
            ErrorDescription,
            InstallDate,
            LastErrorCode,
            Name,
            PNPDeviceID,
            PowerManagementSupported,
            Status,
            StatusInfo,
            SystemCreationClassName,
            SystemName,
            VariableSpeed
        }

        public static string GetfanInfo(fanProp type, string name)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type + " from Win32_Fan Where Name = '" + name + "'");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[type.ToString()].ToString();
            }
            return result;
        }

        public static string GetfanInfo(fanProp type)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type + " From Win32_Fan");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[type.ToString()].ToString();
            }
            return result;
        }

        //service
        public enum ServiceProp
        {
            AcceptPause,
            AcceptStop,
            Caption,
            CheckPoint,
            CreationClassName,
            Description,
            DesktopInteract,
            DisplayName,
            ErrorControl,
            ExitCode,
            InstallDate,
            Name,
            PathName,
            ProcessId,
            ServiceSpecificExitCode,
            ServiceType,
            Started,
            StartMode,
            StartName,
            State,
            Status,
            SystemCreationClassName,
            SystemName,
            TagId,
            WaitHint
        }

        public static string GetserviceInfo(ServiceProp type, string name)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type + " from Win32_Service Where Name = '" + name + "'");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[type.ToString()].ToString();
            }
            return result;
        }

        public static string GetServiceInfo(ServiceProp type)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type + " From Win32_Service");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[type.ToString()].ToString();
            }
            return result;
        }

        //bios
        public enum BIOSProp
        {
            BuildNumber,
            Caption,
            CodeSet,
            CurrentLanguage,
            Description,
            IdentificationCode,
            InstallableLanguages,
            InstallDate,
            LanguageEdition,
            Manufacturer,
            Name,
            OtherTargetOS,
            PrimaryBIOS,
            ReleaseDate,
            SerialNumber,
            SMBIOSBIOSVersion,
            SMBIOSMajorVersion,
            SMBIOSMinorVersion,
            SMBIOSPresent,
            SoftwareElementID,
            SoftwareElementState,
            Status,
            TargetOperatingSystem,
            Version
        }

        public static string GetBIOSInfo(BIOSProp type, string name)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type + " from Win32_BIOS Where Name = '" + name + "'");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[type.ToString()].ToString();
            }
            return result;
        }

        public static string GetBIOSInfo(BIOSProp type)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type + " From Win32_BIOS");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[type.ToString()].ToString();
            }
            return result;
        }

        //Process performance
        public enum processperformanceProp
        {
            Caption,
            CreatingProcessID,
            Description,
            ElapsedTime,
            Frequency_Object,
            Frequency_PerfTime,
            Frequency_Sys100NS,
            HandleCount,
            IDProcess,
            IODataOperationsPerSec,
            IOOtherOperationsPerSec,
            IOReadBytesPerSec,
            IOReadOperationsPerSec,
            IOWriteBytesPerSec,
            IOWriteOperationsPerSec,
            IODataBytesPerSec,
            IOOtherBytesPerSec,
            Name,
            PageFaultsPerSec,
            PageFileBytes,
            PageFileBytesPeak,
            PercentPrivilegedTime,
            PercentProcessorTime,
            PercentUserTime,
            PoolNonpagedBytes,
            PoolPagedBytes,
            PriorityBase,
            PrivateBytes,
            ThreadCount,
            Timestamp_Object,
            Timestamp_PerfTime,
            Timestamp_Sys100NS,
            VirtualBytes,
            VirtualBytesPeak,
            WorkingSet,
            WorkingSetPeak
        }

        public static string GetProcessPerformanceInfo(processperformanceProp type, string name)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type +
                                             " from Win32_PerfRawData_PerfProc_Process Where Name = '" + name +
                                             "'");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[type.ToString()].ToString();
            }
            return result;
        }

        public static string GetProcessPerformanceInfo(processperformanceProp type)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type + " From Win32_PerfRawData_PerfProc_Process");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[type.ToString()].ToString();
            }
            return result;
        }

        //performance
        public enum ProcessorPerformanceProp
        {
            C1TransitionsPerSec,
            C2TransitionsPerSec,
            C3TransitionsPerSec,
            Caption,
            Description,
            DPCRate,
            DPCsQueuedPerSec,
            Frequency_Object,
            Frequency_PerfTime,
            Frequency_Sys100NS,
            InterruptsPerSec,
            Name,
            PercentC1Time,
            PercentC2Time,
            PercentC3Time,
            PercentDPCTime,
            PercentIdleTime,
            PercentInterruptTime,
            PercentPrivilegedTime,
            PercentProcessorTime,
            PercentUserTime,
            Timestamp_Object,
            Timestamp_PerfTime,
            Timestamp_Sys100NS
        }

        public static string GetProcessorPerformanceInfo(ProcessorPerformanceProp type, string name)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type +
                                             " from Win32_PerfRawData_PerfOS_Processor Where Name = '" + name +
                                             "'");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[type.ToString()].ToString();
            }
            return result;
        }

        public static string GetProcessorPerformanceInfo(ProcessorPerformanceProp type)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type + " From Win32_PerfRawData_PerfOS_Processor");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[type.ToString()].ToString();
            }
            return result;
        }

        //performance
        public enum MemoryPerformanceProp
        {
            AvailableBytes,
            AvailableKBytes,
            AvailableMBytes,
            CacheBytes,
            CacheBytesPeak,
            CacheFaultsPerSec,
            Caption,
            CommitLimit,
            CommittedBytes,
            DemandZeroFaultsPerSec,
            Description,
            FreeSystemPageTableEntries,
            Frequency_Object,
            Frequency_PerfTime,
            Frequency_Sys100NS,
            Name,
            PageFaultsPerSec,
            PageReadsPerSec,
            PagesInputPerSec,
            PagesOutputPerSec,
            PagesPerSec,
            PageWritesPerSec,
            PercentCommittedBytesInUse,
            PercentCommittedBytesInUse_Base,
            PoolNonpagedAllocs,
            PoolNonpagedBytes,
            PoolPagedAllocs,
            PoolPagedBytes,
            PoolPagedResidentBytes,
            SystemCacheResidentBytes,
            SystemCodeResidentBytes,
            SystemCodeTotalBytes,
            SystemDriverResidentBytes,
            SystemDriverTotalBytes,
            Timestamp_Object,
            Timestamp_PerfTime,
            Timestamp_Sys100NS,
            TransitionFaultsPerSec,
            WriteCopiesPerSec
        }

        public static string GetMemoryPerformanceInfo(MemoryPerformanceProp type, string name)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type + " from Win32_PerfRawData_PerfOS_Memory Where Name = '" +
                                             name + "'");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[type.ToString()].ToString();
            }
            return result;
        }

        public static string GetMemoryPerformanceInfo(MemoryPerformanceProp type)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type + " From Win32_PerfRawData_PerfOS_Memory");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[type.ToString()].ToString();
            }
            return result;
        }

        //performance
        public enum SystemPerformanceProp
        {
            AlignmentFixupsPerSec,
            Caption,
            ContextSwitchesPerSec,
            Description,
            ExceptionDispatchesPerSec,
            FileControlBytesPerSec,
            FileControlOperationsPerSec,
            FileDataOperationsPerSec,
            FileReadBytesPerSec,
            FileReadOperationsPerSec,
            FileWriteBytesPerSec,
            FileWriteOperationsPerSec,
            FloatingEmulationsPerSec,
            Frequency_Object,
            Frequency_PerfTime,
            Frequency_Sys100NS,
            Name,
            PercentRegistryQuotaInUse,
            PercentRegistryQuotaInUse_Base,
            Processes,
            ProcessorQueueLength,
            SystemCallsPerSec,
            SystemUpTime,
            Threads,
            Timestamp_Object,
            Timestamp_PerfTime,
            Timestamp_Sys100NS
        }

        public static string GetSystemPerformanceInfo(SystemPerformanceProp type, string name)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type + " from Win32_PerfRawData_PerfOS_System Where Name = '" +
                                             name + "'");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[type.ToString()].ToString();
            }
            return result;
        }

        public static string GetSystemPerformanceInfo(SystemPerformanceProp type)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type + " From Win32_PerfRawData_PerfOS_System");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[type.ToString()].ToString();
            }
            return result;
        }

        //performance
        public enum UDPPerformanceProp
        {
            Caption,
            DatagramsNoPortPerSec,
            DatagramsPerSec,
            DatagramsReceivedErrors,
            DatagramsReceivedPerSec,
            DatagramsSentPerSec,
            Description,
            Frequency_Object,
            Frequency_PerfTime,
            Frequency_Sys100NS
        }

        public static string GetUdpPerformanceInfo(UDPPerformanceProp type, string name)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type + " from Win32_PerfRawData_TCPIP_UDP Where Name = '" +
                                             name + "'");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[type.ToString()].ToString();
            }
            return result;
        }

        public static string GetUdpPerformanceInfo(UDPPerformanceProp type)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type + " From Win32_PerfRawData_Tcpip_UDP");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[type.ToString()].ToString();
            }
            return result;
        }

        //performance
        public enum TcpPerformanceProp
        {
            Caption,
            ConnectionFailures,
            ConnectionsActive,
            ConnectionsEstablished,
            ConnectionsPassive,
            ConnectionsReset,
            Description,
            Frequency_Object,
            Frequency_PerfTime,
            Frequency_Sys100NS,
            Name,
            SegmentsPerSec,
            SegmentsReceivedPerSec,
            SegmentsRetransmittedPerSec,
            SegmentsSentPerSec,
            Timestamp_Object,
            Timestamp_PerfTime,
            Timestamp_Sys100NS
        }

        public static string GetTCPPerformanceInfo(TcpPerformanceProp type, string name)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type + " from Win32_PerfRawData_TCPIP_TCP Where Name = '" +
                                             name + "'");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[type.ToString()].ToString();
            }
            return result;
        }

        public static string GetTCPPerformanceInfo(TcpPerformanceProp type)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type + " From Win32_PerfRawData_Tcpip_TCP");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[type.ToString()].ToString();
            }
            return result;
        }

        //memory
        public enum MemoryProp
        {
            BankLabel,
            Capacity,
            Caption,
            CreationClassName,
            DataWidth,
            Description,
            DeviceLocator,
            FormFactor,
            HotSwappable,
            InstallDate,
            InterleaveDataDepth,
            InterleavePosition,
            Manufacturer,
            MemoryType,
            Model,
            Name,
            OtherIdentifyingInfo,
            PartNumber,
            PositionInRow,
            PoweredOn,
            Removable,
            Replaceable,
            SerialNumber,
            SKU,
            Speed,
            Status,
            Tag,
            TotalWidth,
            TypeDetail,
            Version
        }

        public static string GetMemoryInfo(MemoryProp type, string name)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type + " from Win32_PhysicalMemory Where Name = '" + name + "'");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[type.ToString()].ToString();
            }
            return result;
        }

        public static string GetMemoryInfo(MemoryProp type)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type + " From Win32_PhysicalMemory");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[type.ToString()].ToString();
            }
            return result;
        }

        //registry
        public enum RegistryProp
        {
            Caption,
            CurrentSize,
            Description,
            InstallDate,
            MaximumSize,
            Name,
            ProposedSize,
            Status
        }

        public static string GetRegistryInfo(RegistryProp type, string name)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type + " from Win32_Registry Where Name = '" + name + "'");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[type.ToString()].ToString();
            }
            return result;
        }

        public static string GetRegistryInfo(RegistryProp type)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type + " From Win32_Registry");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[type.ToString()].ToString();
            }
            return result;
        }

        public static List<string> GetRegistryInfo_List(RegistryProp type)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type + " From Win32_Registry");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            List<string> result = new List<string>();
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result.Add(managementObject[type.ToString()].ToString());
            }
            return result;
        }

        //Network 
        public enum NetworkProp
        {
            AdapterType,
            AdapterTypeID,
            AutoSense,
            Availability,
            Caption,
            ConfigManagerErrorCode,
            ConfigManagerUserConfig,
            CreationClassName,
            Description,
            DeviceID,
            ErrorCleared,
            ErrorDescription,
            GUID,
            Index,
            InstallDate,
            Installed,
            InterfaceIndex,
            LastErrorCode,
            MACAddress,
            Manufacturer,
            MaxNumberControlled,
            MaxSpeed,
            Name,
            NetConnectionID,
            NetConnectionStatus,
            NetEnabled,
            NetworkAddresses,
            PermanentAddress,
            PhysicalAdapter,
            PNPDeviceID,
            PowerManagementCapabilities,
            PowerManagementSupported,
            ProductName,
            ServiceName,
            Speed,
            Status,
            StatusInfo,
            SystemCreationClassName,
            SystemName,
            TimeOfLastReset
        }

        public static string GetNetworkInfo(NetworkProp type, string name)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type + " from Win32_NetworkAdapter Where Name = '" + name + "'");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[type.ToString()].ToString();
            }
            return result;
        }

        public static string GetNetworkInfo(NetworkProp type)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type + " From Win32_NetworkAdapter");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[type.ToString()].ToString();
            }
            return result;
        }

        public static List<string> GetNetworkInfo_List(NetworkProp type)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type + " From Win32_NetworkAdapter");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();

            List<string> result = new List<string>();
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result.Add(managementObject[type.ToString()].ToString());
            }
            return result;
        }

        //Operating system
        public enum OSProp
        {
            BootDevice,
            BuildNumber,
            BuildType,
            Caption,
            CodeSet,
            CountryCode,
            CreationClassName,
            CSCreationClassName,
            CSDVersion,
            CSName,
            CurrentTimeZone,
            DataExecutionPrevention_Available,
            DataExecutionPrevention_32BitApplications,
            DataExecutionPrevention_Drivers,
            DataExecutionPrevention_SupportPolicy,
            Debug,
            Description,
            Distributed,
            EncryptionLevel,
            ForegroundApplicationBoost,
            FreePhysicalMemory,
            FreeSpaceInPagingFiles,
            FreeVirtualMemory,
            InstallDate,
            LargeSystemCache,
            LastBootUpTime,
            Local,
            Locale,
            Manufacturer,
            MaxNumberOfProcesses,
            MaxProcessMemorySize,
            MUILanguages,
            Name,
            NumberOfLicensedUsers,
            NumberOfProcesses,
            NumberOfUsers,
            OperatingSystemSKU,
            Organization,
            OSArchitecture,
            OSLanguage,
            OSProductSuite,
            OSType,
            OtherTypeDescription,
            PAEEnabled,
            PlusProductID,
            PlusVersionNumber,
            PortableOperatingSystem,
            Primary,
            ProductType,
            RegisteredUser,
            SerialNumber,
            ServicePackMajorVersion,
            ServicePackMinorVersion,
            SizeStoredInPagingFiles,
            Status,
            SuiteMask,
            SystemDevice,
            SystemDirectory,
            SystemDrive,
            TotalSwapSpaceSize,
            TotalVirtualMemorySize,
            TotalVisibleMemorySize,
            Version,
            WindowsDirectory
        }

        public static string GetOsInfo(OSProp type, string name)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type + " from Win32_OperatingSystem Where Name = '" + name +
                                             "'");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[type.ToString()].ToString();
            }
            return result;
        }

        public static string GetOsInfo(OSProp type)
        {
            ManagementObjectSearcher managementObjectSearcher =
                new ManagementObjectSearcher("Select " + type + " From Win32_OperatingSystem");
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            string result = null;
            foreach (ManagementObject managementObject in managementObjectCollection.Cast<ManagementObject>())
            {
                result = managementObject[type.ToString()].ToString();
            }
            return result;
        }

        //general
        public static string InternalIp
        {
            get
            {
                string localIp = "";

                IPHostEntry ipentrylist = Dns.GetHostEntry(Dns.GetHostName());
                bool foundIp = false;
                int i = 0;
                while (foundIp == false)
                {
                    if (ipentrylist.AddressList[i].IsIPv6LinkLocal == false)
                    {
                        localIp = ipentrylist.AddressList[i].ToString();
                        foundIp = true;
                    }
                    i++;
                }
                return localIp;
            }
        }

        public static bool Is64BitOs
        {
            get
            {
                string result;
                // Default to 32-bit for OSes which don't support the OSArchitecture Property of the Win32_OperatingSystem WMI class.
                try
                {
                    result = GetOsInfo(OSProp.OSArchitecture);
                }
                catch (Exception)
                {
                    result = "32-bit";
                }
                return (result != null && result.Contains("64"));
            }
        }

        public static bool Is32BitOs
        {
            get { return (!Is64BitOs); }
        }
    }
}