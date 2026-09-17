using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// Category基础信息
    /// </summary>
    public class BaseCategory 
    {
        /// <summary>
        /// **参数解释**： 租户下项目空间唯一标识ID。 **取值范围**： - -1：自定义工作项类型 - 0：预设工作项模型
        /// </summary>
        /// <value>**参数解释**： 租户下项目空间唯一标识ID。 **取值范围**： - -1：自定义工作项类型 - 0：预设工作项模型</value>
        [JsonConverter(typeof(EnumClassConverter<DomainIdEnum>))]
        public class DomainIdEnum
        {
            /// <summary>
            /// Enum _1 for value: -1
            /// </summary>
            public static readonly DomainIdEnum _1 = new DomainIdEnum("-1");

            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            public static readonly DomainIdEnum _0 = new DomainIdEnum("0");

            private static readonly Dictionary<string, DomainIdEnum> StaticFields =
            new Dictionary<string, DomainIdEnum>()
            {
                { "-1", _1 },
                { "0", _0 },
            };

            private string _value;

            public DomainIdEnum()
            {

            }

            public DomainIdEnum(string value)
            {
                _value = value;
            }

            public static DomainIdEnum FromValue(string value)
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

                if (this.Equals(obj as DomainIdEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DomainIdEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DomainIdEnum a, DomainIdEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(DomainIdEnum a, DomainIdEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 租户ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// **参数解释**： 修改人。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("modified_by", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// **参数解释**： 修改时间。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("modified_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedDate { get; set; }

        /// <summary>
        /// **参数解释**： 创建人。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// **参数解释**： 创建时间。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("created_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// **参数解释**： 对象类型编码。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// **参数解释**： 编号前缀。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string Prefix { get; set; }

        /// <summary>
        /// **参数解释**： 租户下项目空间唯一标识ID。 **取值范围**： - -1：自定义工作项类型 - 0：预设工作项模型
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public DomainIdEnum DomainId { get; set; }
        /// <summary>
        /// **参数解释**： 图标。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        public string Icon { get; set; }

        /// <summary>
        /// **参数解释**： 颜色。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        /// <summary>
        /// **参数解释**： 描述信息。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 定义类型。 **取值范围**： - 1~3 系统级别 - 4 租户级别
        /// </summary>
        [JsonProperty("definition_type", NullValueHandling = NullValueHandling.Ignore)]
        public long? DefinitionType { get; set; }

        /// <summary>
        /// **参数解释**： 类别ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("type_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TypeId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseCategory {\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  modifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  modifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  createdDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  prefix: ").Append(Prefix).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  icon: ").Append(Icon).Append("\n");
            sb.Append("  color: ").Append(Color).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  definitionType: ").Append(DefinitionType).Append("\n");
            sb.Append("  typeId: ").Append(TypeId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BaseCategory);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BaseCategory input)
        {
            if (input == null) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.ModifiedBy != input.ModifiedBy || (this.ModifiedBy != null && !this.ModifiedBy.Equals(input.ModifiedBy))) return false;
            if (this.ModifiedDate != input.ModifiedDate || (this.ModifiedDate != null && !this.ModifiedDate.Equals(input.ModifiedDate))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;
            if (this.CreatedDate != input.CreatedDate || (this.CreatedDate != null && !this.CreatedDate.Equals(input.CreatedDate))) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.Prefix != input.Prefix || (this.Prefix != null && !this.Prefix.Equals(input.Prefix))) return false;
            if (this.DomainId != input.DomainId) return false;
            if (this.Icon != input.Icon || (this.Icon != null && !this.Icon.Equals(input.Icon))) return false;
            if (this.Color != input.Color || (this.Color != null && !this.Color.Equals(input.Color))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.DefinitionType != input.DefinitionType || (this.DefinitionType != null && !this.DefinitionType.Equals(input.DefinitionType))) return false;
            if (this.TypeId != input.TypeId || (this.TypeId != null && !this.TypeId.Equals(input.TypeId))) return false;

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
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.ModifiedBy != null) hashCode = hashCode * 59 + this.ModifiedBy.GetHashCode();
                if (this.ModifiedDate != null) hashCode = hashCode * 59 + this.ModifiedDate.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedDate != null) hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Prefix != null) hashCode = hashCode * 59 + this.Prefix.GetHashCode();
                hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Icon != null) hashCode = hashCode * 59 + this.Icon.GetHashCode();
                if (this.Color != null) hashCode = hashCode * 59 + this.Color.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DefinitionType != null) hashCode = hashCode * 59 + this.DefinitionType.GetHashCode();
                if (this.TypeId != null) hashCode = hashCode * 59 + this.TypeId.GetHashCode();
                return hashCode;
            }
        }
    }
}
