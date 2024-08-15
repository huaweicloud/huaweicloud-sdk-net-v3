using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 负载均衡器规格信息。
    /// </summary>
    public class Flavor 
    {

        /// <summary>
        /// 参数解释：规格ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("info", NullValueHandling = NullValueHandling.Ignore)]
        public FlavorInfo Info { get; set; }

        /// <summary>
        /// 参数解释：规格名称。  取值范围：  网络型有如下规格：   - L4_flavor.elb.s1.small: 小型 I   - L4_flavor.elb.s2.small: 小型 II   - L4_flavor.elb.s1.medium: 中型 I   - L4_flavor.elb.s2.medium: 中型 II   - L4_flavor.elb.s1.large: 大型 I   - L4_flavor.elb.s2.large: 大型 II   - L4_flavor.elb.pro.max: 四层弹性规格  应用型有如下规格：   - L7_flavor.elb.s1.small: 小型 I   - L7_flavor.elb.s2.small: 小型 II   - L7_flavor.elb.s1.medium: 中型 I   - L7_flavor.elb.s2.medium: 中型 II   - L7_flavor.elb.s1.large: 大型 I   - L7_flavor.elb.s2.large: 大型 II   - L7_flavor.elb.s1.extra-large: 超大型 I   - L7_flavor.elb.s2.extra-large: 超大型 II   - L7_flavor.elb.pro.max: 七层弹性规格
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 参数解释：是否公共规格。  取值范围： - true表示公共规格，所有租户可见。 - false表示私有规格，为当前租户所有。
        /// </summary>
        [JsonProperty("shared", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Shared { get; set; }

        /// <summary>
        /// 参数解释：项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 参数解释：规格类别。  取值范围：   - L4和L7 表示四层网络型和七层应用型flavor。   [- gateway 表示网关型LB的flavor，目前只支持弹性计费类型。当前仅支持欧洲局点。](tag:hws_eu)   - L4_elastic和L7_elastic 表示弹性扩缩容实例的下限规格。已废弃，请勿使用。   - L4_elastic_max、L7_elastic_max[和gateway_elastic_max](tag:hws_eu) 表示弹性扩缩容实例的上限规格。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 参数解释：[是否售罄。](tag:hws,hk,hws_eu,otc,tlf,ctc,sbc,g42,cmcc,hk_g42,dt_test,mix,hk_sbc,hws_ocb,dt) [是否无法购买该规格的LB](tag:ocb,tm,fcs,fcs_dt,hcso,hcso_dt,hk_vdf)  取值范围： - true：[已售罄，将](tag:hws,hk,hws_eu,otc,tlf,ctc,sbc,g42,cmcc,hk_g42,dt_test,mix,hk_sbc,hws_ocb,dt)无法购买该规格的LB。 - false：[未售罄，](tag:hws,hk,hws_eu,otc,tlf,ctc,sbc,g42,cmcc,hk_g42,dt_test,mix,hk_sbc,hws_ocb,dt)可购买该规格的LB。
        /// </summary>
        [JsonProperty("flavor_sold_out", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FlavorSoldOut { get; set; }

        /// <summary>
        /// 参数解释：可用区组，如：center
        /// </summary>
        [JsonProperty("public_border_group", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicBorderGroup { get; set; }

        /// <summary>
        /// 参数解释：可用区组编码。  取值范围：0表示center，21表示homezone。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public int? Category { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Flavor {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  info: ").Append(Info).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  shared: ").Append(Shared).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  flavorSoldOut: ").Append(FlavorSoldOut).Append("\n");
            sb.Append("  publicBorderGroup: ").Append(PublicBorderGroup).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Flavor);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Flavor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Info == input.Info ||
                    (this.Info != null &&
                    this.Info.Equals(input.Info))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Shared == input.Shared ||
                    (this.Shared != null &&
                    this.Shared.Equals(input.Shared))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.FlavorSoldOut == input.FlavorSoldOut ||
                    (this.FlavorSoldOut != null &&
                    this.FlavorSoldOut.Equals(input.FlavorSoldOut))
                ) && 
                (
                    this.PublicBorderGroup == input.PublicBorderGroup ||
                    (this.PublicBorderGroup != null &&
                    this.PublicBorderGroup.Equals(input.PublicBorderGroup))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Info != null)
                    hashCode = hashCode * 59 + this.Info.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Shared != null)
                    hashCode = hashCode * 59 + this.Shared.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.FlavorSoldOut != null)
                    hashCode = hashCode * 59 + this.FlavorSoldOut.GetHashCode();
                if (this.PublicBorderGroup != null)
                    hashCode = hashCode * 59 + this.PublicBorderGroup.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                return hashCode;
            }
        }
    }
}
