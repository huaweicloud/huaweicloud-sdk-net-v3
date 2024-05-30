using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// 区域访问控制。   &gt; - 使用该功能需要提交工单开通区域访问控制功能。   &gt; - CDN会定期更新IP地址库，部分未在地址库的IP将无法识别到所属位置。如果CDN无法识别用户所在位置，将采取放行策略，返回对应的资源给用户。
    /// </summary>
    public class AccessAreaFilter 
    {

        /// <summary>
        /// 规则类型，黑、白名单二选一。   - black: 黑名单，如果匹配到黑名单规则，则黑名单所选区域内的用户将无法访问当前资源，返回403状态码。   - white: 白名单，白名单所选区域以外的用户均无法访问当前资源，返回403状态码。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 生效类型。   - all: 所有文件，所有文件均遵循配置的规则。   - file_directory: 目录路径，指定目录路径的资源遵循配置的规则。   - file_path: 全路径，指定路径的资源遵循配置的规则。
        /// </summary>
        [JsonProperty("content_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentType { get; set; }

        /// <summary>
        /// 生效规则。当content_type为all时，为空或不传。 当content_type为file_directory时，输入要求以“/”作为首字符，多个目录以“,”进行分隔，如/test/folder01,/test/folder02，并且输入的目录路径总数不超过100个。 当content_type为file_path时，输入要求以“/”或“\\*”作为首字符，支持配置通配符“\\*”，通配符不能连续出现且不能超过两个。多个路径以“,”进行分割，如/test/a.txt,/test/b.txt，并且输出的总数不能超过100个。   &gt; - 不允许配置两条完全一样的白名单或黑名单规则。   &gt; - 仅允许配置一条生效类型为“所有文件”的规则。
        /// </summary>
        [JsonProperty("content_value", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentValue { get; set; }

        /// <summary>
        /// 配置规则适用的区域，多个区域以“,”进行分隔，支持的区域如：CN_IN：中国大陆，AF：阿富汗，IE：爱尔兰，EG：埃及，AU：澳大利亚等。具体的位置编码参见《附录-地理位置编码》查询。
        /// </summary>
        [JsonProperty("area", NullValueHandling = NullValueHandling.Ignore)]
        public string Area { get; set; }

        /// <summary>
        /// 例外IP，配置指定IP不执行当前规则。
        /// </summary>
        [JsonProperty("exception_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ExceptionIp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessAreaFilter {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  contentType: ").Append(ContentType).Append("\n");
            sb.Append("  contentValue: ").Append(ContentValue).Append("\n");
            sb.Append("  area: ").Append(Area).Append("\n");
            sb.Append("  exceptionIp: ").Append(ExceptionIp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessAreaFilter);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccessAreaFilter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.ContentValue == input.ContentValue ||
                    (this.ContentValue != null &&
                    this.ContentValue.Equals(input.ContentValue))
                ) && 
                (
                    this.Area == input.Area ||
                    (this.Area != null &&
                    this.Area.Equals(input.Area))
                ) && 
                (
                    this.ExceptionIp == input.ExceptionIp ||
                    (this.ExceptionIp != null &&
                    this.ExceptionIp.Equals(input.ExceptionIp))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                if (this.ContentValue != null)
                    hashCode = hashCode * 59 + this.ContentValue.GetHashCode();
                if (this.Area != null)
                    hashCode = hashCode * 59 + this.Area.GetHashCode();
                if (this.ExceptionIp != null)
                    hashCode = hashCode * 59 + this.ExceptionIp.GetHashCode();
                return hashCode;
            }
        }
    }
}
