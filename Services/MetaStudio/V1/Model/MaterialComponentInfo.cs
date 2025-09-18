using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 可替换的素材组件信息
    /// </summary>
    public class MaterialComponentInfo 
    {
        /// <summary>
        /// 素材组件类型。 * CLOTHES：衣服 * PANTS：裤子 * SHOES：鞋子 * HAIR：头发 * EYELASH：睫毛 * EYEBROW：眉毛
        /// </summary>
        /// <value>素材组件类型。 * CLOTHES：衣服 * PANTS：裤子 * SHOES：鞋子 * HAIR：头发 * EYELASH：睫毛 * EYEBROW：眉毛</value>
        [JsonConverter(typeof(EnumClassConverter<ComponentTypeEnum>))]
        public class ComponentTypeEnum
        {
            /// <summary>
            /// Enum CLOTHES for value: CLOTHES
            /// </summary>
            public static readonly ComponentTypeEnum CLOTHES = new ComponentTypeEnum("CLOTHES");

            /// <summary>
            /// Enum PANTS for value: PANTS
            /// </summary>
            public static readonly ComponentTypeEnum PANTS = new ComponentTypeEnum("PANTS");

            /// <summary>
            /// Enum SHOES for value: SHOES
            /// </summary>
            public static readonly ComponentTypeEnum SHOES = new ComponentTypeEnum("SHOES");

            /// <summary>
            /// Enum HAIR for value: HAIR
            /// </summary>
            public static readonly ComponentTypeEnum HAIR = new ComponentTypeEnum("HAIR");

            /// <summary>
            /// Enum EYELASH for value: EYELASH
            /// </summary>
            public static readonly ComponentTypeEnum EYELASH = new ComponentTypeEnum("EYELASH");

            /// <summary>
            /// Enum EYEBROW for value: EYEBROW
            /// </summary>
            public static readonly ComponentTypeEnum EYEBROW = new ComponentTypeEnum("EYEBROW");

            private static readonly Dictionary<string, ComponentTypeEnum> StaticFields =
            new Dictionary<string, ComponentTypeEnum>()
            {
                { "CLOTHES", CLOTHES },
                { "PANTS", PANTS },
                { "SHOES", SHOES },
                { "HAIR", HAIR },
                { "EYELASH", EYELASH },
                { "EYEBROW", EYEBROW },
            };

            private string _value;

            public ComponentTypeEnum()
            {

            }

            public ComponentTypeEnum(string value)
            {
                _value = value;
            }

            public static ComponentTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ComponentTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ComponentTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ComponentTypeEnum a, ComponentTypeEnum b)
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

            public static bool operator !=(ComponentTypeEnum a, ComponentTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 素材组件名称。
        /// </summary>
        [JsonProperty("component_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentName { get; set; }

        /// <summary>
        /// 素材组件类型。 * CLOTHES：衣服 * PANTS：裤子 * SHOES：鞋子 * HAIR：头发 * EYELASH：睫毛 * EYEBROW：眉毛
        /// </summary>
        [JsonProperty("component_type", NullValueHandling = NullValueHandling.Ignore)]
        public ComponentTypeEnum ComponentType { get; set; }
        /// <summary>
        /// 素材组件描述。
        /// </summary>
        [JsonProperty("component_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentDesc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MaterialComponentInfo {\n");
            sb.Append("  componentName: ").Append(ComponentName).Append("\n");
            sb.Append("  componentType: ").Append(ComponentType).Append("\n");
            sb.Append("  componentDesc: ").Append(ComponentDesc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MaterialComponentInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MaterialComponentInfo input)
        {
            if (input == null) return false;
            if (this.ComponentName != input.ComponentName || (this.ComponentName != null && !this.ComponentName.Equals(input.ComponentName))) return false;
            if (this.ComponentType != input.ComponentType) return false;
            if (this.ComponentDesc != input.ComponentDesc || (this.ComponentDesc != null && !this.ComponentDesc.Equals(input.ComponentDesc))) return false;

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
                if (this.ComponentName != null) hashCode = hashCode * 59 + this.ComponentName.GetHashCode();
                hashCode = hashCode * 59 + this.ComponentType.GetHashCode();
                if (this.ComponentDesc != null) hashCode = hashCode * 59 + this.ComponentDesc.GetHashCode();
                return hashCode;
            }
        }
    }
}
