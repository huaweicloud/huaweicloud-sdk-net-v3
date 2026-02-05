using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 构建云应用镜像的请求体。
    /// </summary>
    public class CreateServerImageReq 
    {

        /// <summary>
        /// 镜像名称，名称需满足如下规则: * 首尾字符不能为空格。 * 长度范围1～128个字符。 * 只允许3种字符，英文大小写，数字，特殊字符包含-、.、_、空格和中文。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 镜像描述，描述需满足如下规则: * 首字符不能为空格。 * 长度范围0～1024个字符。 * 支持字母、数字、中文。 * 不支持回车、&lt;、 &gt;字符。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **⚠ : 此属性是预留字段，不需要传值，目前镜像产物默认属于default企业项目** 镜像所属的企业项目ID，默认属于default企业项目。 关于企业项目ID的获取及企业项目特性的详细信息，请参考“[企业中心总览](https://support.huaweicloud.com/zh-cn/usermanual-em/zh-cn_topic_0123692049.html)”。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 是否执行系统封装步骤。
        /// </summary>
        [JsonProperty("execute_sysprep", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExecuteSysprep { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateServerImageReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  executeSysprep: ").Append(ExecuteSysprep).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateServerImageReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateServerImageReq input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.ExecuteSysprep != input.ExecuteSysprep || (this.ExecuteSysprep != null && !this.ExecuteSysprep.Equals(input.ExecuteSysprep))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.ExecuteSysprep != null) hashCode = hashCode * 59 + this.ExecuteSysprep.GetHashCode();
                return hashCode;
            }
        }
    }
}
