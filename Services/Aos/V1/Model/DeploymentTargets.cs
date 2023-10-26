using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// 部署目标信息。
    /// </summary>
    public class DeploymentTargets 
    {

        /// <summary>
        /// 用户指定资源栈集操作所涉及的区域。  *在DeployStackSet API中，根据用户输入regions和domain_ids列表，以笛卡尔积的形式选择资源栈集中存在的资源栈实例进行部署。如果指定了没有被资源栈集所管理的region，则会报错。*
        /// </summary>
        [JsonProperty("regions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Regions { get; set; }

        /// <summary>
        /// 权限模型是SELF_MANAGED时，用户指定包含本次操作涉及到的租户ID内容。  *在DeployStackSet API中，如果指定该参数，根据用户输入的domain_ids列表和regions列表，以笛卡尔积的形式选择资源栈集中存在的资源栈实例进行部署。如果指定了没有被资源栈集所管理的domain_id，则会报错。*  domain_ids和domain_ids_uri 有且仅有一个存在。
        /// </summary>
        [JsonProperty("domain_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DomainIds { get; set; }

        /// <summary>
        /// 权限模型是SELF_MANAGED时，用户指定包含本次操作涉及到的租户ID内容文件的OBS地址。  内容格式要求每个租户ID以逗号（,）分割，支持换行。当前仅支持csv文件，且文件的编码格式须为UTF-8。文件内容大小不超过100KB。  上传的csv文件应尽量避免Excel操作，以防出现读取内容不一致的问题。推荐使用记事本打开确认内容是否符合预期。  *在DeployStackSet API中，如果指定该参数，根据用户输入的domain_ids_uri文件内容和regions列表，以笛卡尔积的形式选择资源栈集中存在的资源栈实例进行部署。如果内容包含了没有被资源栈集所管理的domain_id，则会报错。*  domain_ids和domain_ids_uri有且仅有一个存在。
        /// </summary>
        [JsonProperty("domain_ids_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainIdsUri { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeploymentTargets {\n");
            sb.Append("  regions: ").Append(Regions).Append("\n");
            sb.Append("  domainIds: ").Append(DomainIds).Append("\n");
            sb.Append("  domainIdsUri: ").Append(DomainIdsUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeploymentTargets);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeploymentTargets input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Regions == input.Regions ||
                    this.Regions != null &&
                    input.Regions != null &&
                    this.Regions.SequenceEqual(input.Regions)
                ) && 
                (
                    this.DomainIds == input.DomainIds ||
                    this.DomainIds != null &&
                    input.DomainIds != null &&
                    this.DomainIds.SequenceEqual(input.DomainIds)
                ) && 
                (
                    this.DomainIdsUri == input.DomainIdsUri ||
                    (this.DomainIdsUri != null &&
                    this.DomainIdsUri.Equals(input.DomainIdsUri))
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
                if (this.Regions != null)
                    hashCode = hashCode * 59 + this.Regions.GetHashCode();
                if (this.DomainIds != null)
                    hashCode = hashCode * 59 + this.DomainIds.GetHashCode();
                if (this.DomainIdsUri != null)
                    hashCode = hashCode * 59 + this.DomainIdsUri.GetHashCode();
                return hashCode;
            }
        }
    }
}
