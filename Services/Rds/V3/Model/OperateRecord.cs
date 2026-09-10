using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class OperateRecord 
    {

        /// <summary>
        /// 操作类型
        /// </summary>
        [JsonProperty("operate_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperateType { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [JsonProperty("operate_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? OperateTime { get; set; }

        /// <summary>
        /// 事件等级
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public string Level { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperateRecord {\n");
            sb.Append("  operateType: ").Append(OperateType).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  operateTime: ").Append(OperateTime).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OperateRecord);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OperateRecord input)
        {
            if (input == null) return false;
            if (this.OperateType != input.OperateType || (this.OperateType != null && !this.OperateType.Equals(input.OperateType))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.OperateTime != input.OperateTime || (this.OperateTime != null && !this.OperateTime.Equals(input.OperateTime))) return false;
            if (this.Level != input.Level || (this.Level != null && !this.Level.Equals(input.Level))) return false;

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
                if (this.OperateType != null) hashCode = hashCode * 59 + this.OperateType.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.OperateTime != null) hashCode = hashCode * 59 + this.OperateTime.GetHashCode();
                if (this.Level != null) hashCode = hashCode * 59 + this.Level.GetHashCode();
                return hashCode;
            }
        }
    }
}
