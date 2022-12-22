using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// os-change字段数据结构说明
    /// </summary>
    public class OsChange 
    {

        /// <summary>
        /// 裸金属服务器管理员帐号的初始登录密码。其中，Linux管理员帐户为root，Windows管理员帐户为Administrator。建议密码复杂度如下：长度为8-26位。密码至少必须包含大写字母、小写字母、数字和特殊字符（!@$%^-_&#x3D;+[{}]:,./?）中的三种。密码不能包含用户名或用户名的逆序。 说明：对于Windows裸金属服务器，不能包含用户名中超过两个连续字符的部分。对于Linux裸金属服务器也可使用user_data字段实现密码注入，此时adminpass字段无效。adminpass和keyname不能同时有值。adminpass和keyname如果同时为空，此时，metadata中的user_data属性必须有值。
        /// </summary>
        [JsonProperty("adminpass", NullValueHandling = NullValueHandling.Ignore)]
        public string Adminpass { get; set; }

        /// <summary>
        /// 密钥名称。密钥可以通过7.10.3-创建和导入SSH密钥（OpenStack原生）API创建，或者使用7.10.1-查询SSH密钥列表（OpenStack原生）API查询已有的密钥。
        /// </summary>
        [JsonProperty("keyname", NullValueHandling = NullValueHandling.Ignore)]
        public string Keyname { get; set; }

        /// <summary>
        /// 用户ID（登录管理控制台，进入我的凭证，即可看到“用户ID”）。
        /// </summary>
        [JsonProperty("userid", NullValueHandling = NullValueHandling.Ignore)]
        public string Userid { get; set; }

        /// <summary>
        /// 镜像ID。镜像ID可以从镜像服务控制台获取，或者参考《镜像服务API参考》的“查询镜像列表”章节查询。在使用“查询镜像列表”API查询时，可以添加过滤字段“?virtual_env_type&#x3D;Ironic”来筛选裸金属服务器镜像。
        /// </summary>
        [JsonProperty("imageid", NullValueHandling = NullValueHandling.Ignore)]
        public string Imageid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public MetadataInstall Metadata { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OsChange {\n");
            sb.Append("  adminpass: ").Append(Adminpass).Append("\n");
            sb.Append("  keyname: ").Append(Keyname).Append("\n");
            sb.Append("  userid: ").Append(Userid).Append("\n");
            sb.Append("  imageid: ").Append(Imageid).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OsChange);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OsChange input)
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
                    this.Imageid == input.Imageid ||
                    (this.Imageid != null &&
                    this.Imageid.Equals(input.Imageid))
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
                if (this.Imageid != null)
                    hashCode = hashCode * 59 + this.Imageid.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                return hashCode;
            }
        }
    }
}
