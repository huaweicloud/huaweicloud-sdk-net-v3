using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 设备升级包信息
    /// </summary>
    public class OtaPackageInfo 
    {

        /// <summary>
        /// **参数说明**：升级包ID，用于唯一标识一个升级包。由物联网平台分配获得。 **取值范围**：长度不超过36，只允许字母、数字、连接符（-）的组合。
        /// </summary>
        [JsonProperty("package_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageId { get; set; }

        /// <summary>
        /// **参数说明**：资源空间ID。 **取值范围**：长度不超过36，只允许字母、数字、下划线（_）、连接符（-）的组合。
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// **参数说明**：升级包类型。 **取值范围**：软件包必须设置为：softwarePackage，固件包必须设置为：firmwarePackage。
        /// </summary>
        [JsonProperty("package_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageType { get; set; }

        /// <summary>
        /// **参数说明**：设备关联的产品ID，用于唯一标识一个产品模型，创建产品后获得。方法请参见 [[创建产品](https://support.huaweicloud.com/api-iothub/iot_06_v5_0050.html)](tag:hws)[[创建产品](https://support.huaweicloud.com/intl/zh-cn/api-iothub/iot_06_v5_0050.html)](tag:hws_hk)。 **取值范围**：长度不超过36，只允许字母、数字、下划线（_）、连接符（-）的组合。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// **参数说明**：升级包版本号。 **取值范围**：长度不超过256，只允许字母、数字、下划线（_）、连接符（-）、英文点（.）的组合。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// **参数说明**：支持用于升级此版本包的设备源版本号列表。最多支持20个源版本号。 **取值范围**：源版本号列表，源版本号只允许字母、数字、下划线（_）、连接符（-）、英文点（.）的组合。
        /// </summary>
        [JsonProperty("support_source_versions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportSourceVersions { get; set; }

        /// <summary>
        /// **参数说明**：用于描述升级包的功能等信息。 **取值范围**：长度不超过1024。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数说明**：推送给设备的自定义信息。添加该升级包完成，并创建升级任务后，物联网平台向设备下发升级通知时，会下发该自定义信息给设备。 **取值范围**：长度不超过4096。
        /// </summary>
        [JsonProperty("custom_info", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomInfo { get; set; }

        /// <summary>
        /// 软固件包上传到物联网平台的时间，格式：\&quot;yyyyMMdd&#39;T&#39;HHmmss&#39;Z&#39;\&quot;。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OtaPackageInfo {\n");
            sb.Append("  packageId: ").Append(PackageId).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  packageType: ").Append(PackageType).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  supportSourceVersions: ").Append(SupportSourceVersions).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  customInfo: ").Append(CustomInfo).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OtaPackageInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OtaPackageInfo input)
        {
            if (input == null) return false;
            if (this.PackageId != input.PackageId || (this.PackageId != null && !this.PackageId.Equals(input.PackageId))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.PackageType != input.PackageType || (this.PackageType != null && !this.PackageType.Equals(input.PackageType))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.SupportSourceVersions != input.SupportSourceVersions || (this.SupportSourceVersions != null && input.SupportSourceVersions != null && !this.SupportSourceVersions.SequenceEqual(input.SupportSourceVersions))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.CustomInfo != input.CustomInfo || (this.CustomInfo != null && !this.CustomInfo.Equals(input.CustomInfo))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;

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
                if (this.PackageId != null) hashCode = hashCode * 59 + this.PackageId.GetHashCode();
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.PackageType != null) hashCode = hashCode * 59 + this.PackageType.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.SupportSourceVersions != null) hashCode = hashCode * 59 + this.SupportSourceVersions.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CustomInfo != null) hashCode = hashCode * 59 + this.CustomInfo.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
