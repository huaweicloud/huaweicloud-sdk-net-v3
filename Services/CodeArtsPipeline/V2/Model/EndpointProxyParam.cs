using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// 代理调用外部服务接口参数
    /// </summary>
    public class EndpointProxyParam 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("authorization", NullValueHandling = NullValueHandling.Ignore)]
        public EndpointAuthorizationBody Authorization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Object Data { get; set; }

        /// <summary>
        /// 数据源名称
        /// </summary>
        [JsonProperty("datasource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatasourceName { get; set; }

        /// <summary>
        /// 接入点uuid
        /// </summary>
        [JsonProperty("endpoint_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointUuid { get; set; }

        /// <summary>
        /// 模块id
        /// </summary>
        [JsonProperty("module_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("is_inner", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsInner { get; set; }

        /// <summary>
        /// 项目uuid
        /// </summary>
        [JsonProperty("project_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// 区域名
        /// </summary>
        [JsonProperty("region_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EndpointProxyParam {\n");
            sb.Append("  authorization: ").Append(Authorization).Append("\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("  datasourceName: ").Append(DatasourceName).Append("\n");
            sb.Append("  endpointUuid: ").Append(EndpointUuid).Append("\n");
            sb.Append("  moduleId: ").Append(ModuleId).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  isInner: ").Append(IsInner).Append("\n");
            sb.Append("  projectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  regionName: ").Append(RegionName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EndpointProxyParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EndpointProxyParam input)
        {
            if (input == null) return false;
            if (this.Authorization != input.Authorization || (this.Authorization != null && !this.Authorization.Equals(input.Authorization))) return false;
            if (this.Data != input.Data || (this.Data != null && !this.Data.Equals(input.Data))) return false;
            if (this.DatasourceName != input.DatasourceName || (this.DatasourceName != null && !this.DatasourceName.Equals(input.DatasourceName))) return false;
            if (this.EndpointUuid != input.EndpointUuid || (this.EndpointUuid != null && !this.EndpointUuid.Equals(input.EndpointUuid))) return false;
            if (this.ModuleId != input.ModuleId || (this.ModuleId != null && !this.ModuleId.Equals(input.ModuleId))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.IsInner != input.IsInner || (this.IsInner != null && !this.IsInner.Equals(input.IsInner))) return false;
            if (this.ProjectUuid != input.ProjectUuid || (this.ProjectUuid != null && !this.ProjectUuid.Equals(input.ProjectUuid))) return false;
            if (this.RegionName != input.RegionName || (this.RegionName != null && !this.RegionName.Equals(input.RegionName))) return false;

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
                if (this.Authorization != null) hashCode = hashCode * 59 + this.Authorization.GetHashCode();
                if (this.Data != null) hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.DatasourceName != null) hashCode = hashCode * 59 + this.DatasourceName.GetHashCode();
                if (this.EndpointUuid != null) hashCode = hashCode * 59 + this.EndpointUuid.GetHashCode();
                if (this.ModuleId != null) hashCode = hashCode * 59 + this.ModuleId.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.IsInner != null) hashCode = hashCode * 59 + this.IsInner.GetHashCode();
                if (this.ProjectUuid != null) hashCode = hashCode * 59 + this.ProjectUuid.GetHashCode();
                if (this.RegionName != null) hashCode = hashCode * 59 + this.RegionName.GetHashCode();
                return hashCode;
            }
        }
    }
}
