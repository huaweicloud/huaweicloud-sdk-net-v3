using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 重装操作系统body。
    /// </summary>
    public class ReinstallServerWithoutCloudInitOption 
    {

        /// <summary>
        /// 云服务器管理员帐户的初始登录密码。  其中，Windows管理员帐户的用户名为Administrator。  建议密码复杂度如下：  - 长度为8-26位。 - 密码至少必须包含大写字母、小写字母、数字和特殊字符（!@$%^-_&#x3D;+[{}]:,./?）中的三种。  &gt; 说明： &gt;  - 对于Windows弹性云服务器，密码不能包含用户名或用户名的逆序，不能包含用户名中超过两个连续字符的部分。 - adminpass和keyname不能同时为空。
        /// </summary>
        [JsonProperty("adminpass", NullValueHandling = NullValueHandling.Ignore)]
        public string Adminpass { get; set; }

        /// <summary>
        /// 密钥名称。  密钥可以通过密钥创建接口进行创建（请参见[创建和导入SSH密钥](https://support.huaweicloud.com/api-ecs/zh-cn_topic_0020212678.html)），或使用SSH密钥查询接口查询已有的密钥（请参见[查询SSH密钥列表](https://support.huaweicloud.com/api-ecs/ecs_03_1201.html) ）。
        /// </summary>
        [JsonProperty("keyname", NullValueHandling = NullValueHandling.Ignore)]
        public string Keyname { get; set; }

        /// <summary>
        /// 用户ID。当传入keyname参数时，此参数为必选。
        /// </summary>
        [JsonProperty("userid", NullValueHandling = NullValueHandling.Ignore)]
        public string Userid { get; set; }

        /// <summary>
        /// 取值为withStopServer ，支持开机状态下切换弹性云服务器操作系统。 mode取值为withStopServer时，对开机状态的弹性云服务器执行切换操作系统操作，系统自动对云服务器先执行关机，再切换操作系统。
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public ReinstallSeverMetadataWithoutCloudInitOption Metadata { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReinstallServerWithoutCloudInitOption {\n");
            sb.Append("  adminpass: ").Append(Adminpass).Append("\n");
            sb.Append("  keyname: ").Append(Keyname).Append("\n");
            sb.Append("  userid: ").Append(Userid).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReinstallServerWithoutCloudInitOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReinstallServerWithoutCloudInitOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Adminpass == input.Adminpass ||
                    (this.Adminpass != null &&
                    this.Adminpass.Equals(input.Adminpass))
                ) && 
                (
                    this.Keyname == input.Keyname ||
                    (this.Keyname != null &&
                    this.Keyname.Equals(input.Keyname))
                ) && 
                (
                    this.Userid == input.Userid ||
                    (this.Userid != null &&
                    this.Userid.Equals(input.Userid))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
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
                if (this.Adminpass != null)
                    hashCode = hashCode * 59 + this.Adminpass.GetHashCode();
                if (this.Keyname != null)
                    hashCode = hashCode * 59 + this.Keyname.GetHashCode();
                if (this.Userid != null)
                    hashCode = hashCode * 59 + this.Userid.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                return hashCode;
            }
        }
    }
}
