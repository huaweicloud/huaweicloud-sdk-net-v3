using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ModResourceDTO 
    {

        /// <summary>
        /// 资源标识。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 资源类型，企业内ID和TYPE唯一标识一个资源项，若只传资源ID可能会修改多个资源的信息。 - VMR        - 云会议室 - CONF_CALL  - 会议并发数 - HARD_1080P - 1080P硬终端 - HARD_720P  - 720P硬终端 - SOFT       - 软终端用户数 - ROOM       - 大屏软终端 - LIVE       - 直播推流 - RECORD     - 录播空间 - HARD_THIRD_PARTY - 第三方硬终端帐号 - HUAWEI_VISION -智慧屏
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 到期时间。
        /// </summary>
        [JsonProperty("expireDate", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpireDate { get; set; }

        /// <summary>
        /// 资源是否被停用。
        /// </summary>
        [JsonProperty("isDisabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDisabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModResourceDTO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  expireDate: ").Append(ExpireDate).Append("\n");
            sb.Append("  isDisabled: ").Append(IsDisabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModResourceDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModResourceDTO input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.ExpireDate != input.ExpireDate || (this.ExpireDate != null && !this.ExpireDate.Equals(input.ExpireDate))) return false;
            if (this.IsDisabled != input.IsDisabled || (this.IsDisabled != null && !this.IsDisabled.Equals(input.IsDisabled))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ExpireDate != null) hashCode = hashCode * 59 + this.ExpireDate.GetHashCode();
                if (this.IsDisabled != null) hashCode = hashCode * 59 + this.IsDisabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
