using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListStorageTypeRequest 
    {
        /// <summary>
        /// 数据库版本类型： - 取值为“DDS-Community”。
        /// </summary>
        /// <value>数据库版本类型： - 取值为“DDS-Community”。</value>
        [JsonConverter(typeof(EnumClassConverter<EngineNameEnum>))]
        public class EngineNameEnum
        {
            /// <summary>
            /// Enum DDS_COMMUNITY for value: DDS-Community
            /// </summary>
            public static readonly EngineNameEnum DDS_COMMUNITY = new EngineNameEnum("DDS-Community");

            /// <summary>
            /// Enum DDS_ENHANCED for value: DDS-Enhanced
            /// </summary>
            public static readonly EngineNameEnum DDS_ENHANCED = new EngineNameEnum("DDS-Enhanced");

            private static readonly Dictionary<string, EngineNameEnum> StaticFields =
            new Dictionary<string, EngineNameEnum>()
            {
                { "DDS-Community", DDS_COMMUNITY },
                { "DDS-Enhanced", DDS_ENHANCED },
            };

            private string _value;

            public EngineNameEnum()
            {

            }

            public EngineNameEnum(string value)
            {
                _value = value;
            }

            public static EngineNameEnum FromValue(string value)
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

                if (this.Equals(obj as EngineNameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EngineNameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EngineNameEnum a, EngineNameEnum b)
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

            public static bool operator !=(EngineNameEnum a, EngineNameEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 数据库版本类型： - 取值为“DDS-Community”。
        /// </summary>
        [SDKProperty("engine_name", IsQuery = true)]
        [JsonProperty("engine_name", NullValueHandling = NullValueHandling.Ignore)]
        public EngineNameEnum EngineName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListStorageTypeRequest {\n");
            sb.Append("  engineName: ").Append(EngineName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListStorageTypeRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListStorageTypeRequest input)
        {
            if (input == null) return false;
            if (this.EngineName != input.EngineName) return false;

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
                hashCode = hashCode * 59 + this.EngineName.GetHashCode();
                return hashCode;
            }
        }
    }
}
