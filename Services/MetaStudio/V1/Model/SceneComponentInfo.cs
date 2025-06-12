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
    /// 场景组件信息。
    /// </summary>
    public class SceneComponentInfo 
    {
        /// <summary>
        /// 组件类型。 * CAMERA：摄像机 * PANEL：屏幕 * LIGHT：灯光
        /// </summary>
        /// <value>组件类型。 * CAMERA：摄像机 * PANEL：屏幕 * LIGHT：灯光</value>
        [JsonConverter(typeof(EnumClassConverter<ComponentTypeEnum>))]
        public class ComponentTypeEnum
        {
            /// <summary>
            /// Enum CAMERA for value: CAMERA
            /// </summary>
            public static readonly ComponentTypeEnum CAMERA = new ComponentTypeEnum("CAMERA");

            /// <summary>
            /// Enum PANEL for value: PANEL
            /// </summary>
            public static readonly ComponentTypeEnum PANEL = new ComponentTypeEnum("PANEL");

            /// <summary>
            /// Enum LIGHT for value: LIGHT
            /// </summary>
            public static readonly ComponentTypeEnum LIGHT = new ComponentTypeEnum("LIGHT");

            private static readonly Dictionary<string, ComponentTypeEnum> StaticFields =
            new Dictionary<string, ComponentTypeEnum>()
            {
                { "CAMERA", CAMERA },
                { "PANEL", PANEL },
                { "LIGHT", LIGHT },
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

            public static bool operator !=(ComponentTypeEnum a, ComponentTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 组件索引。
        /// </summary>
        [JsonProperty("index", NullValueHandling = NullValueHandling.Ignore)]
        public int? Index { get; set; }

        /// <summary>
        /// 组件名称。
        /// </summary>
        [JsonProperty("component_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentName { get; set; }

        /// <summary>
        /// 组件类型。 * CAMERA：摄像机 * PANEL：屏幕 * LIGHT：灯光
        /// </summary>
        [JsonProperty("component_type", NullValueHandling = NullValueHandling.Ignore)]
        public ComponentTypeEnum ComponentType { get; set; }
        /// <summary>
        /// 组件描述。
        /// </summary>
        [JsonProperty("component_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentDesc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SceneComponentInfo {\n");
            sb.Append("  index: ").Append(Index).Append("\n");
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
            return this.Equals(input as SceneComponentInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SceneComponentInfo input)
        {
            if (input == null) return false;
            if (this.Index != input.Index || (this.Index != null && !this.Index.Equals(input.Index))) return false;
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
                if (this.Index != null) hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.ComponentName != null) hashCode = hashCode * 59 + this.ComponentName.GetHashCode();
                hashCode = hashCode * 59 + this.ComponentType.GetHashCode();
                if (this.ComponentDesc != null) hashCode = hashCode * 59 + this.ComponentDesc.GetHashCode();
                return hashCode;
            }
        }
    }
}
