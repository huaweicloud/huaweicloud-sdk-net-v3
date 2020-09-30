using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateKeyRequestBody 
    {
        /// <summary>
        /// 密钥来源，默认为“kms”，枚举如下： - kms：表示密钥材料由kms生成。 - external：表示密钥材料由外部导入。
        /// </summary>
        /// <value>密钥来源，默认为“kms”，枚举如下： - kms：表示密钥材料由kms生成。 - external：表示密钥材料由外部导入。</value>
        [JsonConverter(typeof(EnumClassConverter<OriginEnum>))]
        public class OriginEnum
        {
            /// <summary>
            /// Enum KMS for value: kms
            /// </summary>
            public static readonly OriginEnum KMS = new OriginEnum("kms");

            /// <summary>
            /// Enum EXTERNAL for value: external
            /// </summary>
            public static readonly OriginEnum EXTERNAL = new OriginEnum("external");

            private static readonly Dictionary<string, OriginEnum> StaticFields =
            new Dictionary<string, OriginEnum>()
            {
                { "kms", KMS },
                { "external", EXTERNAL },
            };

            private string Value;

            private OriginEnum(string value)
            {
                this.Value = value;
            }

            public static OriginEnum FromValue(string value)
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

                if (this.Equals(obj as OriginEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OriginEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(OriginEnum a, OriginEnum b)
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

            public static bool operator !=(OriginEnum a, OriginEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 非默认主密钥别名，取值范围为1到255个字符，满足正则匹配“^[a-zA-Z0-9:/_-]{1,255}$”，且不与系统服务创建的默认主密钥别名重名。
        /// </summary>
        [JsonProperty("key_alias", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyAlias { get; set; }

        /// <summary>
        /// 密钥描述，取值0到255字符。
        /// </summary>
        [JsonProperty("key_description", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyDescription { get; set; }

        /// <summary>
        /// 密钥来源，默认为“kms”，枚举如下： - kms：表示密钥材料由kms生成。 - external：表示密钥材料由外部导入。
        /// </summary>
        [JsonProperty("origin", NullValueHandling = NullValueHandling.Ignore)]
        public OriginEnum Origin { get; set; }
        /// <summary>
        /// 企业多项目ID。 - 用户未开通企业多项目时，不需要输入该字段。 - 用户开通企业多项目时，创建资源可以输入该字段。若用户户不输入该字段，默认创建属于默认企业多项目ID（ID为“0”）的资源。 注意：若用户没有默认企业多项目ID（ID为“0”）下的创建权限，则接口报错。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 请求消息序列号，36字节序列号。 例如：919c82d4-8046-4722-9094-35c3c6524cff
        /// </summary>
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public string Sequence { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateKeyRequestBody {\n");
            sb.Append("  keyAlias: ").Append(KeyAlias).Append("\n");
            sb.Append("  keyDescription: ").Append(KeyDescription).Append("\n");
            sb.Append("  origin: ").Append(Origin).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateKeyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateKeyRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeyAlias == input.KeyAlias ||
                    (this.KeyAlias != null &&
                    this.KeyAlias.Equals(input.KeyAlias))
                ) && 
                (
                    this.KeyDescription == input.KeyDescription ||
                    (this.KeyDescription != null &&
                    this.KeyDescription.Equals(input.KeyDescription))
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.Sequence == input.Sequence ||
                    (this.Sequence != null &&
                    this.Sequence.Equals(input.Sequence))
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
                if (this.KeyAlias != null)
                    hashCode = hashCode * 59 + this.KeyAlias.GetHashCode();
                if (this.KeyDescription != null)
                    hashCode = hashCode * 59 + this.KeyDescription.GetHashCode();
                if (this.Origin != null)
                    hashCode = hashCode * 59 + this.Origin.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                return hashCode;
            }
        }
    }
}
