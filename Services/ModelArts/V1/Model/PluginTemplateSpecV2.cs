using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 插件模板的具体信息。
    /// </summary>
    public class PluginTemplateSpecV2 
    {
        /// <summary>
        /// **参数解释**：插件模板类型。 **取值范围**：可选值如下： - helm：helm类型 - ccePlugin：CCE类型
        /// </summary>
        /// <value>**参数解释**：插件模板类型。 **取值范围**：可选值如下： - helm：helm类型 - ccePlugin：CCE类型</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum HELM for value: helm
            /// </summary>
            public static readonly TypeEnum HELM = new TypeEnum("helm");

            /// <summary>
            /// Enum _CCEPLUGIN for value:  ccePlugin
            /// </summary>
            public static readonly TypeEnum _CCEPLUGIN = new TypeEnum(" ccePlugin");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "helm", HELM },
                { " ccePlugin", _CCEPLUGIN },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：是否为必安装插件。 **取值范围**： - true：是 - false：否
        /// </summary>
        [JsonProperty("optional", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Optional { get; set; }

        /// <summary>
        /// **参数解释**：插件模板类型。 **取值范围**：可选值如下： - helm：helm类型 - ccePlugin：CCE类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// **参数解释**：Logo图片地址。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("logoURL", NullValueHandling = NullValueHandling.Ignore)]
        public string LogoURL { get; set; }

        /// <summary>
        /// **参数解释**：插件模板描述。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**：插件模板版本的详细信息。
        /// </summary>
        [JsonProperty("versions", NullValueHandling = NullValueHandling.Ignore)]
        public List<PluginTemplateVersionV2> Versions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PluginTemplateSpecV2 {\n");
            sb.Append("  optional: ").Append(Optional).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  logoURL: ").Append(LogoURL).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  versions: ").Append(Versions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PluginTemplateSpecV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PluginTemplateSpecV2 input)
        {
            if (input == null) return false;
            if (this.Optional != input.Optional || (this.Optional != null && !this.Optional.Equals(input.Optional))) return false;
            if (this.Type != input.Type) return false;
            if (this.LogoURL != input.LogoURL || (this.LogoURL != null && !this.LogoURL.Equals(input.LogoURL))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Versions != input.Versions || (this.Versions != null && input.Versions != null && !this.Versions.SequenceEqual(input.Versions))) return false;

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
                if (this.Optional != null) hashCode = hashCode * 59 + this.Optional.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.LogoURL != null) hashCode = hashCode * 59 + this.LogoURL.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Versions != null) hashCode = hashCode * 59 + this.Versions.GetHashCode();
                return hashCode;
            }
        }
    }
}
