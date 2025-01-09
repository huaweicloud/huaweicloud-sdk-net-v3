using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 文件重定向控制的选项。
    /// </summary>
    public class PoliciesFileAndClipboardFileRedirectionOptions 
    {

        /// <summary>
        /// 是否开启流控开关。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("fluid_control_switch_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FluidControlSwitchEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fluid_control_options", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesFileAndClipboardFileRedirectionOptionsFluidControlOptions FluidControlOptions { get; set; }

        /// <summary>
        /// 是否开启压缩开关。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("compression_switch_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CompressionSwitchEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("compression_switch_options", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesFileAndClipboardFileRedirectionOptionsCompressionSwitchOptions CompressionSwitchOptions { get; set; }

        /// <summary>
        /// 是否开启Linux支持设置文件大小。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("linux_file_size_supported_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LinuxFileSizeSupportedEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("linux_file_size_supported_options", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesFileAndClipboardFileRedirectionOptionsLinuxFileSizeSupportedOptions LinuxFileSizeSupportedOptions { get; set; }

        /// <summary>
        /// 是否开启Linux根目录挂载开关。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("linux_root_mount_switch_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LinuxRootMountSwitchEnable { get; set; }

        /// <summary>
        /// Linux根目录挂载路径。默认：\&quot;\\var\\log\&quot;。
        /// </summary>
        [JsonProperty("linux_root_dir_list", NullValueHandling = NullValueHandling.Ignore)]
        public string LinuxRootDirList { get; set; }

        /// <summary>
        /// Linux文件系统挂载路径。默认：\&quot;\\media|\\Volumes|\\swdb\\mnt|\\home|\\storage|\\tmp|\\run\\media\&quot;。
        /// </summary>
        [JsonProperty("linux_file_mount_path", NullValueHandling = NullValueHandling.Ignore)]
        public string LinuxFileMountPath { get; set; }

        /// <summary>
        /// Linux固定驱动器文件系统格式。
        /// </summary>
        [JsonProperty("linux_fixed_drive_file_system_format", NullValueHandling = NullValueHandling.Ignore)]
        public string LinuxFixedDriveFileSystemFormat { get; set; }

        /// <summary>
        /// Linux可移动驱动器文件系统格式。默认：\&quot;vfat|ntfs|msdos|fuseblk|sdcardfs|exfat|fuse.fdredir|lifs\&quot;。
        /// </summary>
        [JsonProperty("linux_removable_drive_file_system_format", NullValueHandling = NullValueHandling.Ignore)]
        public string LinuxRemovableDriveFileSystemFormat { get; set; }

        /// <summary>
        /// Linux光盘驱动器文件系统格式。默认：\&quot;cd9660|iso9660|udf\&quot;。
        /// </summary>
        [JsonProperty("linux_cdrom_drive_file_system_format", NullValueHandling = NullValueHandling.Ignore)]
        public string LinuxCdromDriveFileSystemFormat { get; set; }

        /// <summary>
        /// Linux网络驱动器文件系统格式。默认：\&quot;smbfs|afpfs|cifs\&quot;。
        /// </summary>
        [JsonProperty("linux_network_drive_file_system_format", NullValueHandling = NullValueHandling.Ignore)]
        public string LinuxNetworkDriveFileSystemFormat { get; set; }

        /// <summary>
        /// 路径分隔符。默认：\&quot;|\&quot;。
        /// </summary>
        [JsonProperty("path_separator", NullValueHandling = NullValueHandling.Ignore)]
        public string PathSeparator { get; set; }

        /// <summary>
        /// 是否开启固定驱动器（如: 本地磁盘）。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("fixed_drive_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FixedDriveEnable { get; set; }

        /// <summary>
        /// 是否开启可移除驱动器（如: U盘）。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("removable_drive_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RemovableDriveEnable { get; set; }

        /// <summary>
        /// 是否开启光盘驱动器。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("cd_rom_drive_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CdRomDriveEnable { get; set; }

        /// <summary>
        /// 是否开启网络驱动器。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("network_drive_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NetworkDriveEnable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesFileAndClipboardFileRedirectionOptions {\n");
            sb.Append("  fluidControlSwitchEnable: ").Append(FluidControlSwitchEnable).Append("\n");
            sb.Append("  fluidControlOptions: ").Append(FluidControlOptions).Append("\n");
            sb.Append("  compressionSwitchEnable: ").Append(CompressionSwitchEnable).Append("\n");
            sb.Append("  compressionSwitchOptions: ").Append(CompressionSwitchOptions).Append("\n");
            sb.Append("  linuxFileSizeSupportedEnable: ").Append(LinuxFileSizeSupportedEnable).Append("\n");
            sb.Append("  linuxFileSizeSupportedOptions: ").Append(LinuxFileSizeSupportedOptions).Append("\n");
            sb.Append("  linuxRootMountSwitchEnable: ").Append(LinuxRootMountSwitchEnable).Append("\n");
            sb.Append("  linuxRootDirList: ").Append(LinuxRootDirList).Append("\n");
            sb.Append("  linuxFileMountPath: ").Append(LinuxFileMountPath).Append("\n");
            sb.Append("  linuxFixedDriveFileSystemFormat: ").Append(LinuxFixedDriveFileSystemFormat).Append("\n");
            sb.Append("  linuxRemovableDriveFileSystemFormat: ").Append(LinuxRemovableDriveFileSystemFormat).Append("\n");
            sb.Append("  linuxCdromDriveFileSystemFormat: ").Append(LinuxCdromDriveFileSystemFormat).Append("\n");
            sb.Append("  linuxNetworkDriveFileSystemFormat: ").Append(LinuxNetworkDriveFileSystemFormat).Append("\n");
            sb.Append("  pathSeparator: ").Append(PathSeparator).Append("\n");
            sb.Append("  fixedDriveEnable: ").Append(FixedDriveEnable).Append("\n");
            sb.Append("  removableDriveEnable: ").Append(RemovableDriveEnable).Append("\n");
            sb.Append("  cdRomDriveEnable: ").Append(CdRomDriveEnable).Append("\n");
            sb.Append("  networkDriveEnable: ").Append(NetworkDriveEnable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesFileAndClipboardFileRedirectionOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesFileAndClipboardFileRedirectionOptions input)
        {
            if (input == null) return false;
            if (this.FluidControlSwitchEnable != input.FluidControlSwitchEnable || (this.FluidControlSwitchEnable != null && !this.FluidControlSwitchEnable.Equals(input.FluidControlSwitchEnable))) return false;
            if (this.FluidControlOptions != input.FluidControlOptions || (this.FluidControlOptions != null && !this.FluidControlOptions.Equals(input.FluidControlOptions))) return false;
            if (this.CompressionSwitchEnable != input.CompressionSwitchEnable || (this.CompressionSwitchEnable != null && !this.CompressionSwitchEnable.Equals(input.CompressionSwitchEnable))) return false;
            if (this.CompressionSwitchOptions != input.CompressionSwitchOptions || (this.CompressionSwitchOptions != null && !this.CompressionSwitchOptions.Equals(input.CompressionSwitchOptions))) return false;
            if (this.LinuxFileSizeSupportedEnable != input.LinuxFileSizeSupportedEnable || (this.LinuxFileSizeSupportedEnable != null && !this.LinuxFileSizeSupportedEnable.Equals(input.LinuxFileSizeSupportedEnable))) return false;
            if (this.LinuxFileSizeSupportedOptions != input.LinuxFileSizeSupportedOptions || (this.LinuxFileSizeSupportedOptions != null && !this.LinuxFileSizeSupportedOptions.Equals(input.LinuxFileSizeSupportedOptions))) return false;
            if (this.LinuxRootMountSwitchEnable != input.LinuxRootMountSwitchEnable || (this.LinuxRootMountSwitchEnable != null && !this.LinuxRootMountSwitchEnable.Equals(input.LinuxRootMountSwitchEnable))) return false;
            if (this.LinuxRootDirList != input.LinuxRootDirList || (this.LinuxRootDirList != null && !this.LinuxRootDirList.Equals(input.LinuxRootDirList))) return false;
            if (this.LinuxFileMountPath != input.LinuxFileMountPath || (this.LinuxFileMountPath != null && !this.LinuxFileMountPath.Equals(input.LinuxFileMountPath))) return false;
            if (this.LinuxFixedDriveFileSystemFormat != input.LinuxFixedDriveFileSystemFormat || (this.LinuxFixedDriveFileSystemFormat != null && !this.LinuxFixedDriveFileSystemFormat.Equals(input.LinuxFixedDriveFileSystemFormat))) return false;
            if (this.LinuxRemovableDriveFileSystemFormat != input.LinuxRemovableDriveFileSystemFormat || (this.LinuxRemovableDriveFileSystemFormat != null && !this.LinuxRemovableDriveFileSystemFormat.Equals(input.LinuxRemovableDriveFileSystemFormat))) return false;
            if (this.LinuxCdromDriveFileSystemFormat != input.LinuxCdromDriveFileSystemFormat || (this.LinuxCdromDriveFileSystemFormat != null && !this.LinuxCdromDriveFileSystemFormat.Equals(input.LinuxCdromDriveFileSystemFormat))) return false;
            if (this.LinuxNetworkDriveFileSystemFormat != input.LinuxNetworkDriveFileSystemFormat || (this.LinuxNetworkDriveFileSystemFormat != null && !this.LinuxNetworkDriveFileSystemFormat.Equals(input.LinuxNetworkDriveFileSystemFormat))) return false;
            if (this.PathSeparator != input.PathSeparator || (this.PathSeparator != null && !this.PathSeparator.Equals(input.PathSeparator))) return false;
            if (this.FixedDriveEnable != input.FixedDriveEnable || (this.FixedDriveEnable != null && !this.FixedDriveEnable.Equals(input.FixedDriveEnable))) return false;
            if (this.RemovableDriveEnable != input.RemovableDriveEnable || (this.RemovableDriveEnable != null && !this.RemovableDriveEnable.Equals(input.RemovableDriveEnable))) return false;
            if (this.CdRomDriveEnable != input.CdRomDriveEnable || (this.CdRomDriveEnable != null && !this.CdRomDriveEnable.Equals(input.CdRomDriveEnable))) return false;
            if (this.NetworkDriveEnable != input.NetworkDriveEnable || (this.NetworkDriveEnable != null && !this.NetworkDriveEnable.Equals(input.NetworkDriveEnable))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.FluidControlSwitchEnable != null) hashCode = hashCode * 59 + this.FluidControlSwitchEnable.GetHashCode();
                if (this.FluidControlOptions != null) hashCode = hashCode * 59 + this.FluidControlOptions.GetHashCode();
                if (this.CompressionSwitchEnable != null) hashCode = hashCode * 59 + this.CompressionSwitchEnable.GetHashCode();
                if (this.CompressionSwitchOptions != null) hashCode = hashCode * 59 + this.CompressionSwitchOptions.GetHashCode();
                if (this.LinuxFileSizeSupportedEnable != null) hashCode = hashCode * 59 + this.LinuxFileSizeSupportedEnable.GetHashCode();
                if (this.LinuxFileSizeSupportedOptions != null) hashCode = hashCode * 59 + this.LinuxFileSizeSupportedOptions.GetHashCode();
                if (this.LinuxRootMountSwitchEnable != null) hashCode = hashCode * 59 + this.LinuxRootMountSwitchEnable.GetHashCode();
                if (this.LinuxRootDirList != null) hashCode = hashCode * 59 + this.LinuxRootDirList.GetHashCode();
                if (this.LinuxFileMountPath != null) hashCode = hashCode * 59 + this.LinuxFileMountPath.GetHashCode();
                if (this.LinuxFixedDriveFileSystemFormat != null) hashCode = hashCode * 59 + this.LinuxFixedDriveFileSystemFormat.GetHashCode();
                if (this.LinuxRemovableDriveFileSystemFormat != null) hashCode = hashCode * 59 + this.LinuxRemovableDriveFileSystemFormat.GetHashCode();
                if (this.LinuxCdromDriveFileSystemFormat != null) hashCode = hashCode * 59 + this.LinuxCdromDriveFileSystemFormat.GetHashCode();
                if (this.LinuxNetworkDriveFileSystemFormat != null) hashCode = hashCode * 59 + this.LinuxNetworkDriveFileSystemFormat.GetHashCode();
                if (this.PathSeparator != null) hashCode = hashCode * 59 + this.PathSeparator.GetHashCode();
                if (this.FixedDriveEnable != null) hashCode = hashCode * 59 + this.FixedDriveEnable.GetHashCode();
                if (this.RemovableDriveEnable != null) hashCode = hashCode * 59 + this.RemovableDriveEnable.GetHashCode();
                if (this.CdRomDriveEnable != null) hashCode = hashCode * 59 + this.CdRomDriveEnable.GetHashCode();
                if (this.NetworkDriveEnable != null) hashCode = hashCode * 59 + this.NetworkDriveEnable.GetHashCode();
                return hashCode;
            }
        }
    }
}
