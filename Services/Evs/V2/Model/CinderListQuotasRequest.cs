using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class CinderListQuotasRequest 
    {
        /// <summary>
        /// Defines usage
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<UsageEnum>))]
        public class UsageEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly UsageEnum TRUE = new UsageEnum("true");

            private static readonly Dictionary<string, UsageEnum> StaticFields =
            new Dictionary<string, UsageEnum>()
            {
                { "true", TRUE },
            };

            private string Value;

            public UsageEnum(string value)
            {
                Value = value;
            }

            public static UsageEnum FromValue(string value)
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

                if (this.Equals(obj as UsageEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(UsageEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(UsageEnum a, UsageEnum b)
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

            public static bool operator !=(UsageEnum a, UsageEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("target_project_id", IsPath = true)]
        [JsonProperty("target_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("usage", IsQuery = true)]
        [JsonProperty("usage", NullValueHandling = NullValueHandling.Ignore)]
        public UsageEnum Usage { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CinderListQuotasRequest {\n");
            sb.Append("  targetProjectId: ").Append(TargetProjectId).Append("\n");
            sb.Append("  usage: ").Append(Usage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CinderListQuotasRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CinderListQuotasRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TargetProjectId == input.TargetProjectId ||
                    (this.TargetProjectId != null &&
                    this.TargetProjectId.Equals(input.TargetProjectId))
                ) && 
                (
                    this.Usage == input.Usage ||
                    (this.Usage != null &&
                    this.Usage.Equals(input.Usage))
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
                if (this.TargetProjectId != null)
                    hashCode = hashCode * 59 + this.TargetProjectId.GetHashCode();
                if (this.Usage != null)
                    hashCode = hashCode * 59 + this.Usage.GetHashCode();
                return hashCode;
            }
        }
    }
}
