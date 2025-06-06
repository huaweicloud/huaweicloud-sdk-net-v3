using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateResourceGroupRequestBody 
    {
        /// <summary>
        /// 资源层级，资源生效范围。选择云产品，则云产品及其子层级均可进入该资源分组，选择子维度，则只生效具体的子维度 product 云产品 dimension 子维度 
        /// </summary>
        /// <value>资源层级，资源生效范围。选择云产品，则云产品及其子层级均可进入该资源分组，选择子维度，则只生效具体的子维度 product 云产品 dimension 子维度 </value>
        [JsonConverter(typeof(EnumClassConverter<ResourceLevelEnum>))]
        public class ResourceLevelEnum
        {
            /// <summary>
            /// Enum PRODUCT for value: product
            /// </summary>
            public static readonly ResourceLevelEnum PRODUCT = new ResourceLevelEnum("product");

            /// <summary>
            /// Enum DIMENSION for value: dimension
            /// </summary>
            public static readonly ResourceLevelEnum DIMENSION = new ResourceLevelEnum("dimension");

            private static readonly Dictionary<string, ResourceLevelEnum> StaticFields =
            new Dictionary<string, ResourceLevelEnum>()
            {
                { "product", PRODUCT },
                { "dimension", DIMENSION },
            };

            private string _value;

            public ResourceLevelEnum()
            {

            }

            public ResourceLevelEnum(string value)
            {
                _value = value;
            }

            public static ResourceLevelEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as ResourceLevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResourceLevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResourceLevelEnum a, ResourceLevelEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ResourceLevelEnum a, ResourceLevelEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 资源分组的名称，只能为字母、数字、汉字、-、_，最大长度为128
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// 资源分组归属企业项目ID
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 资源分组添加资源方式，取值只能为EPS（同步企业项目）,TAG（标签动态匹配）,NAME（实例名称）,不传为手动添加
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 标签动态匹配时的关联标签,type为TAG时必传
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceGroupTagRelation> Tags { get; set; }

        /// <summary>
        /// 该资源分组内包含的资源来源的企业项目ID，type为EPS时必传
        /// </summary>
        [JsonProperty("association_ep_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssociationEpIds { get; set; }

        /// <summary>
        /// 云服务名称,格式为\&quot;dcs,ecs\&quot;,支持的云服务providers请参考https://support.huaweicloud.com/api-rms/rms_06_0100.html
        /// </summary>
        [JsonProperty("providers", NullValueHandling = NullValueHandling.Ignore)]
        public string Providers { get; set; }

        /// <summary>
        /// 组合匹配参数
        /// </summary>
        [JsonProperty("enterprise_project_id_and_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<EnterpriseProjectIdAndTags> EnterpriseProjectIdAndTags { get; set; }

        /// <summary>
        /// 手动创建时的资源详情
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<Resource> Resources { get; set; }

        /// <summary>
        /// 手动创建，选择资源层级为云产品时的资源详情
        /// </summary>
        [JsonProperty("product_resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProductResource> ProductResources { get; set; }

        /// <summary>
        /// 实例名称匹配参数
        /// </summary>
        [JsonProperty("instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<Instance> Instances { get; set; }

        /// <summary>
        /// 创建资源层级为云产品时的云产品的取值，一般由\&quot;服务命名空间,服务首层维度名称\&quot;组成，如\&quot;SYS.ECS,instance_id\&quot;。多个云产品则用“;”隔开，如\&quot;SERVICE.BMS,instance_id;SYS.ECS,instance_id\&quot;。
        /// </summary>
        [JsonProperty("product_names", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductNames { get; set; }

        /// <summary>
        /// 资源层级，资源生效范围。选择云产品，则云产品及其子层级均可进入该资源分组，选择子维度，则只生效具体的子维度 product 云产品 dimension 子维度 
        /// </summary>
        [JsonProperty("resource_level", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceLevelEnum ResourceLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("comb_relation", NullValueHandling = NullValueHandling.Ignore)]
        public CombRelation CombRelation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateResourceGroupRequestBody {\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  associationEpIds: ").Append(AssociationEpIds).Append("\n");
            sb.Append("  providers: ").Append(Providers).Append("\n");
            sb.Append("  enterpriseProjectIdAndTags: ").Append(EnterpriseProjectIdAndTags).Append("\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("  productResources: ").Append(ProductResources).Append("\n");
            sb.Append("  instances: ").Append(Instances).Append("\n");
            sb.Append("  productNames: ").Append(ProductNames).Append("\n");
            sb.Append("  resourceLevel: ").Append(ResourceLevel).Append("\n");
            sb.Append("  combRelation: ").Append(CombRelation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateResourceGroupRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateResourceGroupRequestBody input)
        {
            if (input == null) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.AssociationEpIds != input.AssociationEpIds || (this.AssociationEpIds != null && input.AssociationEpIds != null && !this.AssociationEpIds.SequenceEqual(input.AssociationEpIds))) return false;
            if (this.Providers != input.Providers || (this.Providers != null && !this.Providers.Equals(input.Providers))) return false;
            if (this.EnterpriseProjectIdAndTags != input.EnterpriseProjectIdAndTags || (this.EnterpriseProjectIdAndTags != null && input.EnterpriseProjectIdAndTags != null && !this.EnterpriseProjectIdAndTags.SequenceEqual(input.EnterpriseProjectIdAndTags))) return false;
            if (this.Resources != input.Resources || (this.Resources != null && input.Resources != null && !this.Resources.SequenceEqual(input.Resources))) return false;
            if (this.ProductResources != input.ProductResources || (this.ProductResources != null && input.ProductResources != null && !this.ProductResources.SequenceEqual(input.ProductResources))) return false;
            if (this.Instances != input.Instances || (this.Instances != null && input.Instances != null && !this.Instances.SequenceEqual(input.Instances))) return false;
            if (this.ProductNames != input.ProductNames || (this.ProductNames != null && !this.ProductNames.Equals(input.ProductNames))) return false;
            if (this.ResourceLevel != input.ResourceLevel) return false;
            if (this.CombRelation != input.CombRelation || (this.CombRelation != null && !this.CombRelation.Equals(input.CombRelation))) return false;

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
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.AssociationEpIds != null) hashCode = hashCode * 59 + this.AssociationEpIds.GetHashCode();
                if (this.Providers != null) hashCode = hashCode * 59 + this.Providers.GetHashCode();
                if (this.EnterpriseProjectIdAndTags != null) hashCode = hashCode * 59 + this.EnterpriseProjectIdAndTags.GetHashCode();
                if (this.Resources != null) hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.ProductResources != null) hashCode = hashCode * 59 + this.ProductResources.GetHashCode();
                if (this.Instances != null) hashCode = hashCode * 59 + this.Instances.GetHashCode();
                if (this.ProductNames != null) hashCode = hashCode * 59 + this.ProductNames.GetHashCode();
                hashCode = hashCode * 59 + this.ResourceLevel.GetHashCode();
                if (this.CombRelation != null) hashCode = hashCode * 59 + this.CombRelation.GetHashCode();
                return hashCode;
            }
        }
    }
}
