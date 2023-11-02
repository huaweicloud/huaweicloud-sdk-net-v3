using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 包周期实例变更规格请求
    /// </summary>
    public class CreateResizeOrderRequestBody 
    {

        /// <summary>
        /// 自动开启安全组规则
        /// </summary>
        [JsonProperty("auto_open_security_group_rule", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoOpenSecurityGroupRule { get; set; }

        /// <summary>
        /// 启动迅速
        /// </summary>
        [JsonProperty("execute_immediately", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExecuteImmediately { get; set; }

        /// <summary>
        /// 新的容量，单位是GB
        /// </summary>
        [JsonProperty("new_capacity", NullValueHandling = NullValueHandling.Ignore)]
        public float? NewCapacity { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// 区域代码
        /// </summary>
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateResizeOrderRequestBody {\n");
            sb.Append("  autoOpenSecurityGroupRule: ").Append(AutoOpenSecurityGroupRule).Append("\n");
            sb.Append("  executeImmediately: ").Append(ExecuteImmediately).Append("\n");
            sb.Append("  newCapacity: ").Append(NewCapacity).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateResizeOrderRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateResizeOrderRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutoOpenSecurityGroupRule == input.AutoOpenSecurityGroupRule ||
                    (this.AutoOpenSecurityGroupRule != null &&
                    this.AutoOpenSecurityGroupRule.Equals(input.AutoOpenSecurityGroupRule))
                ) && 
                (
                    this.ExecuteImmediately == input.ExecuteImmediately ||
                    (this.ExecuteImmediately != null &&
                    this.ExecuteImmediately.Equals(input.ExecuteImmediately))
                ) && 
                (
                    this.NewCapacity == input.NewCapacity ||
                    (this.NewCapacity != null &&
                    this.NewCapacity.Equals(input.NewCapacity))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.SpecCode == input.SpecCode ||
                    (this.SpecCode != null &&
                    this.SpecCode.Equals(input.SpecCode))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AutoOpenSecurityGroupRule != null)
                    hashCode = hashCode * 59 + this.AutoOpenSecurityGroupRule.GetHashCode();
                if (this.ExecuteImmediately != null)
                    hashCode = hashCode * 59 + this.ExecuteImmediately.GetHashCode();
                if (this.NewCapacity != null)
                    hashCode = hashCode * 59 + this.NewCapacity.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.SpecCode != null)
                    hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
