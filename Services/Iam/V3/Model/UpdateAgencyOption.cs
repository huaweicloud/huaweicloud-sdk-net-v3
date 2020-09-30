using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateAgencyOption 
    {
        /// <summary>
        /// 委托的期限。取值为“FOREVER\&quot;表示委托的期限为永久，取值为\&quot;ONEDAY\&quot;表示委托的期限为一天。四个参数至少填写一个。
        /// </summary>
        /// <value>委托的期限。取值为“FOREVER\&quot;表示委托的期限为永久，取值为\&quot;ONEDAY\&quot;表示委托的期限为一天。四个参数至少填写一个。</value>
        [JsonConverter(typeof(EnumClassConverter<DurationEnum>))]
        public class DurationEnum
        {
            /// <summary>
            /// Enum FOREVER for value: FOREVER
            /// </summary>
            public static readonly DurationEnum FOREVER = new DurationEnum("FOREVER");

            /// <summary>
            /// Enum ONEDAY for value: ONEDAY
            /// </summary>
            public static readonly DurationEnum ONEDAY = new DurationEnum("ONEDAY");

            private static readonly Dictionary<string, DurationEnum> StaticFields =
            new Dictionary<string, DurationEnum>()
            {
                { "FOREVER", FOREVER },
                { "ONEDAY", ONEDAY },
            };

            private string Value;

            private DurationEnum(string value)
            {
                this.Value = value;
            }

            public static DurationEnum FromValue(string value)
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
                return this.Value;
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

                if (this.Equals(obj as DurationEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DurationEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(DurationEnum a, DurationEnum b)
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

            public static bool operator !=(DurationEnum a, DurationEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 被委托方账号ID。如果trust_domain_id和trust_domain_name都填写，则优先校验trust_domain_name。四个参数至少填写一个。
        /// </summary>
        [JsonProperty("trust_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TrustDomainId { get; set; }

        /// <summary>
        /// 被委托方账号名。如果trust_domain_id和trust_domain_name都填写，则优先校验trust_domain_name。四个参数至少填写一个。
        /// </summary>
        [JsonProperty("trust_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TrustDomainName { get; set; }

        /// <summary>
        /// 委托描述信息，长度不大于255位。四个参数至少填写一个。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 委托的期限。取值为“FOREVER\&quot;表示委托的期限为永久，取值为\&quot;ONEDAY\&quot;表示委托的期限为一天。四个参数至少填写一个。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public DurationEnum Duration { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAgencyOption {\n");
            sb.Append("  trustDomainId: ").Append(TrustDomainId).Append("\n");
            sb.Append("  trustDomainName: ").Append(TrustDomainName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAgencyOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAgencyOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TrustDomainId == input.TrustDomainId ||
                    (this.TrustDomainId != null &&
                    this.TrustDomainId.Equals(input.TrustDomainId))
                ) && 
                (
                    this.TrustDomainName == input.TrustDomainName ||
                    (this.TrustDomainName != null &&
                    this.TrustDomainName.Equals(input.TrustDomainName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
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
                if (this.TrustDomainId != null)
                    hashCode = hashCode * 59 + this.TrustDomainId.GetHashCode();
                if (this.TrustDomainName != null)
                    hashCode = hashCode * 59 + this.TrustDomainName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                return hashCode;
            }
        }
    }
}
