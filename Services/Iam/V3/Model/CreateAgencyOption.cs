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
    public class CreateAgencyOption 
    {
        /// <summary>
        /// 委托的期限。取值为“FOREVER\&quot;表示委托的期限为永久，取值为\&quot;ONEDAY\&quot;表示委托的期限为一天。不填写该参数则默认为\&quot;null\&quot;也表示委托的期限为永久。
        /// </summary>
        /// <value>委托的期限。取值为“FOREVER\&quot;表示委托的期限为永久，取值为\&quot;ONEDAY\&quot;表示委托的期限为一天。不填写该参数则默认为\&quot;null\&quot;也表示委托的期限为永久。</value>
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

            public DurationEnum(string value)
            {
                Value = value;
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
        /// 委托名，长度不大于64位。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 委托方账号ID。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 被委托方账号ID。trust_domain_id和trust_domain_name至少填写一个，若都填写优先校验trust_domain_name。
        /// </summary>
        [JsonProperty("trust_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TrustDomainId { get; set; }

        /// <summary>
        /// 被委托方账号名。trust_domain_id和trust_domain_name至少填写一个，若都填写优先校验trust_domain_name。
        /// </summary>
        [JsonProperty("trust_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TrustDomainName { get; set; }

        /// <summary>
        /// 委托描述信息，长度不大于255位。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 委托的期限。取值为“FOREVER\&quot;表示委托的期限为永久，取值为\&quot;ONEDAY\&quot;表示委托的期限为一天。不填写该参数则默认为\&quot;null\&quot;也表示委托的期限为永久。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public DurationEnum Duration { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAgencyOption {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
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
            return this.Equals(input as CreateAgencyOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAgencyOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
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
