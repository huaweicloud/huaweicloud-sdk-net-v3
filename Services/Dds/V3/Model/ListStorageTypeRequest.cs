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
        /// Defines engineName
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<EngineNameEnum>))]
        public class EngineNameEnum
        {
            /// <summary>
            /// Enum DDS_COMMUNITY for value: DDS-Community
            /// </summary>
            public static readonly EngineNameEnum DDS_COMMUNITY = new EngineNameEnum("DDS-Community");

            private static readonly Dictionary<string, EngineNameEnum> StaticFields =
            new Dictionary<string, EngineNameEnum>()
            {
                { "DDS-Community", DDS_COMMUNITY },
            };

            private string Value;

            public EngineNameEnum(string value)
            {
                Value = value;
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 
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
            if (input == null)
                return false;

            return 
                (
                    this.EngineName == input.EngineName ||
                    (this.EngineName != null &&
                    this.EngineName.Equals(input.EngineName))
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
                if (this.EngineName != null)
                    hashCode = hashCode * 59 + this.EngineName.GetHashCode();
                return hashCode;
            }
        }
    }
}
