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
    /// 升级包在OBS的位置
    /// </summary>
    public class ObsLocation 
    {

        /// <summary>
        /// **参数说明**：OBS所在区域。您可以从[[地区和终端节点](https://developer.huaweicloud.com/endpoint?OBS)](tag:hws)[[地区和终端节点](https://developer.huaweicloud.com/intl/zh-cn/endpoint?OBS)](tag:hws_hk)中查询服务的终端节点。 **取值范围**：长度不超过256，只允许字母、数字、连接符（-）的组合。
        /// </summary>
        [JsonProperty("region_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionName { get; set; }

        /// <summary>
        /// **参数说明**：OBS桶名称。 **取值范围**：长度最小为3，最大为63，只允许小写字母、数字、连接符（-）、英文点（.）的组合。
        /// </summary>
        [JsonProperty("bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BucketName { get; set; }

        /// <summary>
        /// **参数说明**：OBS对象名称(包含文件夹路径)。 **取值范围**：长度不超过1024。
        /// </summary>
        [JsonProperty("object_key", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectKey { get; set; }

        /// <summary>
        /// **参数说明**： **取值范围**：只支持SHA256,不携带默认为SHA256。
        /// </summary>
        [JsonProperty("sign_method", NullValueHandling = NullValueHandling.Ignore)]
        public string SignMethod { get; set; }

        /// <summary>
        /// **参数说明**：SHA256算法计算出的升级包签名值。添加该升级包完成，并创建升级任务后，物联网平台向设备下发升级通知时，会下发该签名给设备。 **取值范围**：长度为64，只允许大小写字母a到f、数字的组合。
        /// </summary>
        [JsonProperty("sign", NullValueHandling = NullValueHandling.Ignore)]
        public string Sign { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObsLocation {\n");
            sb.Append("  regionName: ").Append(RegionName).Append("\n");
            sb.Append("  bucketName: ").Append(BucketName).Append("\n");
            sb.Append("  objectKey: ").Append(ObjectKey).Append("\n");
            sb.Append("  signMethod: ").Append(SignMethod).Append("\n");
            sb.Append("  sign: ").Append(Sign).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObsLocation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ObsLocation input)
        {
            if (input == null) return false;
            if (this.RegionName != input.RegionName || (this.RegionName != null && !this.RegionName.Equals(input.RegionName))) return false;
            if (this.BucketName != input.BucketName || (this.BucketName != null && !this.BucketName.Equals(input.BucketName))) return false;
            if (this.ObjectKey != input.ObjectKey || (this.ObjectKey != null && !this.ObjectKey.Equals(input.ObjectKey))) return false;
            if (this.SignMethod != input.SignMethod || (this.SignMethod != null && !this.SignMethod.Equals(input.SignMethod))) return false;
            if (this.Sign != input.Sign || (this.Sign != null && !this.Sign.Equals(input.Sign))) return false;

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
                if (this.RegionName != null) hashCode = hashCode * 59 + this.RegionName.GetHashCode();
                if (this.BucketName != null) hashCode = hashCode * 59 + this.BucketName.GetHashCode();
                if (this.ObjectKey != null) hashCode = hashCode * 59 + this.ObjectKey.GetHashCode();
                if (this.SignMethod != null) hashCode = hashCode * 59 + this.SignMethod.GetHashCode();
                if (this.Sign != null) hashCode = hashCode * 59 + this.Sign.GetHashCode();
                return hashCode;
            }
        }
    }
}
