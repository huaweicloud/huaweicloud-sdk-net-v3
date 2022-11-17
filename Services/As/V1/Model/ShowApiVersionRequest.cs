using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowApiVersionRequest 
    {
        /// <summary>
        /// API版本ID。
        /// </summary>
        /// <value>API版本ID。</value>
        [JsonConverter(typeof(EnumClassConverter<ApiVersionEnum>))]
        public class ApiVersionEnum
        {
            /// <summary>
            /// Enum V1 for value: v1
            /// </summary>
            public static readonly ApiVersionEnum V1 = new ApiVersionEnum("v1");

            /// <summary>
            /// Enum V2 for value: v2
            /// </summary>
            public static readonly ApiVersionEnum V2 = new ApiVersionEnum("v2");

            private static readonly Dictionary<string, ApiVersionEnum> StaticFields =
            new Dictionary<string, ApiVersionEnum>()
            {
                { "v1", V1 },
                { "v2", V2 },
            };

            private string Value;

            public ApiVersionEnum(string value)
            {
                Value = value;
            }

            public static ApiVersionEnum FromValue(string value)
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

                if (this.Equals(obj as ApiVersionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ApiVersionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ApiVersionEnum a, ApiVersionEnum b)
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

            public static bool operator !=(ApiVersionEnum a, ApiVersionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// API版本ID。
        /// </summary>
        [SDKProperty("api_version", IsPath = true)]
        [JsonProperty("api_version", NullValueHandling = NullValueHandling.Ignore)]
        public ApiVersionEnum ApiVersion { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowApiVersionRequest {\n");
            sb.Append("  apiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowApiVersionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowApiVersionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiVersion == input.ApiVersion ||
                    (this.ApiVersion != null &&
                    this.ApiVersion.Equals(input.ApiVersion))
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
                if (this.ApiVersion != null)
                    hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
