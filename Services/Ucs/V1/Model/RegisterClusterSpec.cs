using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 集群spec信息。
    /// </summary>
    public class RegisterClusterSpec 
    {

        /// <summary>
        /// 容器舰队ID信息。
        /// </summary>
        [JsonProperty("clusterGroupID", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterGroupID { get; set; }

        /// <summary>
        /// 集群类别，填写需要与provider和type对应，具体请参见[集群类别与类型说明](ucs_api_0024.xml)。 
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// 集群类型，填写需要与category和provider对应，具体请参见[集群类别与类型说明](ucs_api_0024.xml)。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 供应商，填写需要与category和type对应，具体请参见[集群类别与类型说明](ucs_api_0024.xml)。 
        /// </summary>
        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public string Provider { get; set; }

        /// <summary>
        /// 所在国家代码，具体代码请参见[国家码](ucs_api_0022.xml)。
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// 所在城市代码，具体代码请参见[城市码](ucs_api_0023.xml)。仅支持中国城市，其他国家无需填写。
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// 地域信息。仅在CCE导入集群注册时使用。可通过[获取未注册到UCS的CCE集群](ListManagedClusters.xml)接口的region字段获取。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 项目ID信息。仅在CCE导入集群注册时使用。可通过[获取未注册到UCS的CCE集群](ListManagedClusters.xml)接口的projectID字段获取。
        /// </summary>
        [JsonProperty("projectID", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectID { get; set; }

        /// <summary>
        /// 集群管理类型信息。 取值如下： - grouped：在舰队中纳管的集群 - discrete：未加入舰队的集群
        /// </summary>
        [JsonProperty("manageType", NullValueHandling = NullValueHandling.Ignore)]
        public string ManageType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("network", NullValueHandling = NullValueHandling.Ignore)]
        public NetworkConfig Network { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegisterClusterSpec {\n");
            sb.Append("  clusterGroupID: ").Append(ClusterGroupID).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  provider: ").Append(Provider).Append("\n");
            sb.Append("  country: ").Append(Country).Append("\n");
            sb.Append("  city: ").Append(City).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  projectID: ").Append(ProjectID).Append("\n");
            sb.Append("  manageType: ").Append(ManageType).Append("\n");
            sb.Append("  network: ").Append(Network).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RegisterClusterSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RegisterClusterSpec input)
        {
            if (input == null) return false;
            if (this.ClusterGroupID != input.ClusterGroupID || (this.ClusterGroupID != null && !this.ClusterGroupID.Equals(input.ClusterGroupID))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Provider != input.Provider || (this.Provider != null && !this.Provider.Equals(input.Provider))) return false;
            if (this.Country != input.Country || (this.Country != null && !this.Country.Equals(input.Country))) return false;
            if (this.City != input.City || (this.City != null && !this.City.Equals(input.City))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.ProjectID != input.ProjectID || (this.ProjectID != null && !this.ProjectID.Equals(input.ProjectID))) return false;
            if (this.ManageType != input.ManageType || (this.ManageType != null && !this.ManageType.Equals(input.ManageType))) return false;
            if (this.Network != input.Network || (this.Network != null && !this.Network.Equals(input.Network))) return false;

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
                if (this.ClusterGroupID != null) hashCode = hashCode * 59 + this.ClusterGroupID.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Provider != null) hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.Country != null) hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.City != null) hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.ProjectID != null) hashCode = hashCode * 59 + this.ProjectID.GetHashCode();
                if (this.ManageType != null) hashCode = hashCode * 59 + this.ManageType.GetHashCode();
                if (this.Network != null) hashCode = hashCode * 59 + this.Network.GetHashCode();
                return hashCode;
            }
        }
    }
}
