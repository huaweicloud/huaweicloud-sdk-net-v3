using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListKeysRequestBody 
    {
        /// <summary>
        /// 密钥生成算法，默认为“AES_256”。查询所有（包含非对称）密钥需要指定参数“ALL”。  - AES_256  - SM4  - RSA_2048  - RSA_3072  - RSA_4096  - EC_P256  - EC_P384  - SM2  - ALL
        /// </summary>
        /// <value>密钥生成算法，默认为“AES_256”。查询所有（包含非对称）密钥需要指定参数“ALL”。  - AES_256  - SM4  - RSA_2048  - RSA_3072  - RSA_4096  - EC_P256  - EC_P384  - SM2  - ALL</value>
        [JsonConverter(typeof(EnumClassConverter<KeySpecEnum>))]
        public class KeySpecEnum
        {
            /// <summary>
            /// Enum AES_256 for value: AES_256
            /// </summary>
            public static readonly KeySpecEnum AES_256 = new KeySpecEnum("AES_256");

            /// <summary>
            /// Enum SM4 for value: SM4
            /// </summary>
            public static readonly KeySpecEnum SM4 = new KeySpecEnum("SM4");

            /// <summary>
            /// Enum RSA_2048 for value: RSA_2048
            /// </summary>
            public static readonly KeySpecEnum RSA_2048 = new KeySpecEnum("RSA_2048");

            /// <summary>
            /// Enum RSA_3072 for value: RSA_3072
            /// </summary>
            public static readonly KeySpecEnum RSA_3072 = new KeySpecEnum("RSA_3072");

            /// <summary>
            /// Enum RSA_4096 for value: RSA_4096
            /// </summary>
            public static readonly KeySpecEnum RSA_4096 = new KeySpecEnum("RSA_4096");

            /// <summary>
            /// Enum EC_P256 for value: EC_P256
            /// </summary>
            public static readonly KeySpecEnum EC_P256 = new KeySpecEnum("EC_P256");

            /// <summary>
            /// Enum EC_P384 for value: EC_P384
            /// </summary>
            public static readonly KeySpecEnum EC_P384 = new KeySpecEnum("EC_P384");

            /// <summary>
            /// Enum SM2 for value: SM2
            /// </summary>
            public static readonly KeySpecEnum SM2 = new KeySpecEnum("SM2");

            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            public static readonly KeySpecEnum ALL = new KeySpecEnum("ALL");

            private static readonly Dictionary<string, KeySpecEnum> StaticFields =
            new Dictionary<string, KeySpecEnum>()
            {
                { "AES_256", AES_256 },
                { "SM4", SM4 },
                { "RSA_2048", RSA_2048 },
                { "RSA_3072", RSA_3072 },
                { "RSA_4096", RSA_4096 },
                { "EC_P256", EC_P256 },
                { "EC_P384", EC_P384 },
                { "SM2", SM2 },
                { "ALL", ALL },
            };

            private string _value;

            public KeySpecEnum()
            {

            }

            public KeySpecEnum(string value)
            {
                _value = value;
            }

            public static KeySpecEnum FromValue(string value)
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

                if (this.Equals(obj as KeySpecEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(KeySpecEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(KeySpecEnum a, KeySpecEnum b)
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

            public static bool operator !=(KeySpecEnum a, KeySpecEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 指定查询返回记录条数，如果指定查询记录条数小于存在的条数，响应参数“truncated”将返回“true”，表示存在分页。取值在密钥最大个数范围以内。例如：100
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        /// <summary>
        /// 分页查询起始位置标识。分页查询收到的响应参数“truncated”为“true”时，可以发送连续的请求获取更多的记录条数，“marker”设置为响应的next_marker的值。例如：10
        /// </summary>
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 密钥状态，满足正则匹配“^[1-5]{1}$”，枚举如下：  - “1”表示待激活状态  - “2”表示启用状态  - “3”表示禁用状态  - “4”表示计划删除状态  - “5”表示等待导入状态
        /// </summary>
        [JsonProperty("key_state", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyState { get; set; }

        /// <summary>
        /// 密钥生成算法，默认为“AES_256”。查询所有（包含非对称）密钥需要指定参数“ALL”。  - AES_256  - SM4  - RSA_2048  - RSA_3072  - RSA_4096  - EC_P256  - EC_P384  - SM2  - ALL
        /// </summary>
        [JsonProperty("key_spec", NullValueHandling = NullValueHandling.Ignore)]
        public KeySpecEnum KeySpec { get; set; }
        /// <summary>
        /// 企业多项目ID。用户未开通企业多项目时，不需要输入该字段。 用户开通企业多项目时，查询资源可以输入该字段。 若用户不输入该字段，默认查询租户所有有权限的企业多项目下的资源。 此时“enterprise_project_id”取值为“all”。 若用户输入该字段，取值满足以下任一条件. - 取值为“all” - 取值为“0” - 满足正则匹配：“^[0-9a-z]{8}-[0-9a-z]{4}-[0-9a-z]{4}-[0-9a-z]{4}-[0-9a-z]{12}$”
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
            sb.Append("class ListKeysRequestBody {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  keyState: ").Append(KeyState).Append("\n");
            sb.Append("  keySpec: ").Append(KeySpec).Append("\n");
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
            return this.Equals(input as ListKeysRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListKeysRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.KeyState == input.KeyState ||
                    (this.KeyState != null &&
                    this.KeyState.Equals(input.KeyState))
                ) && 
                (
                    this.KeySpec == input.KeySpec ||
                    (this.KeySpec != null &&
                    this.KeySpec.Equals(input.KeySpec))
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
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.KeyState != null)
                    hashCode = hashCode * 59 + this.KeyState.GetHashCode();
                if (this.KeySpec != null)
                    hashCode = hashCode * 59 + this.KeySpec.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                return hashCode;
            }
        }
    }
}
