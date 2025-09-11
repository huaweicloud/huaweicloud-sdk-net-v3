using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateInstanceRequestBody 
    {
        /// <summary>
        /// 企业仓库实例规格，目前支持企业版(swr.ee.professional)
        /// </summary>
        /// <value>企业仓库实例规格，目前支持企业版(swr.ee.professional)</value>
        [JsonConverter(typeof(EnumClassConverter<SpecEnum>))]
        public class SpecEnum
        {
            /// <summary>
            /// Enum SWR_EE_BASIC for value: swr.ee.basic
            /// </summary>
            public static readonly SpecEnum SWR_EE_BASIC = new SpecEnum("swr.ee.basic");

            /// <summary>
            /// Enum SWR_EE_PROFESSIONAL for value: swr.ee.professional
            /// </summary>
            public static readonly SpecEnum SWR_EE_PROFESSIONAL = new SpecEnum("swr.ee.professional");

            private static readonly Dictionary<string, SpecEnum> StaticFields =
            new Dictionary<string, SpecEnum>()
            {
                { "swr.ee.basic", SWR_EE_BASIC },
                { "swr.ee.professional", SWR_EE_PROFESSIONAL },
            };

            private string _value;

            public SpecEnum()
            {

            }

            public SpecEnum(string value)
            {
                _value = value;
            }

            public static SpecEnum FromValue(string value)
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

                if (this.Equals(obj as SpecEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SpecEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SpecEnum a, SpecEnum b)
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

            public static bool operator !=(SpecEnum a, SpecEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 实例计费模式，目前只支持按需(postPaid)
        /// </summary>
        /// <value>实例计费模式，目前只支持按需(postPaid)</value>
        [JsonConverter(typeof(EnumClassConverter<ChargeModeEnum>))]
        public class ChargeModeEnum
        {
            /// <summary>
            /// Enum POSTPAID for value: postPaid
            /// </summary>
            public static readonly ChargeModeEnum POSTPAID = new ChargeModeEnum("postPaid");

            private static readonly Dictionary<string, ChargeModeEnum> StaticFields =
            new Dictionary<string, ChargeModeEnum>()
            {
                { "postPaid", POSTPAID },
            };

            private string _value;

            public ChargeModeEnum()
            {

            }

            public ChargeModeEnum(string value)
            {
                _value = value;
            }

            public static ChargeModeEnum FromValue(string value)
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

                if (this.Equals(obj as ChargeModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ChargeModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ChargeModeEnum a, ChargeModeEnum b)
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

            public static bool operator !=(ChargeModeEnum a, ChargeModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// obs桶加密类型，空值使用AES-256加密算法, gm为国密加密算法
        /// </summary>
        /// <value>obs桶加密类型，空值使用AES-256加密算法, gm为国密加密算法</value>
        [JsonConverter(typeof(EnumClassConverter<EncryptTypeEnum>))]
        public class EncryptTypeEnum
        {
            /// <summary>
            /// Enum GM for value: gm
            /// </summary>
            public static readonly EncryptTypeEnum GM = new EncryptTypeEnum("gm");

            private static readonly Dictionary<string, EncryptTypeEnum> StaticFields =
            new Dictionary<string, EncryptTypeEnum>()
            {
                { "gm", GM },
            };

            private string _value;

            public EncryptTypeEnum()
            {

            }

            public EncryptTypeEnum(string value)
            {
                _value = value;
            }

            public static EncryptTypeEnum FromValue(string value)
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

                if (this.Equals(obj as EncryptTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EncryptTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EncryptTypeEnum a, EncryptTypeEnum b)
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

            public static bool operator !=(EncryptTypeEnum a, EncryptTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 企业仓库实例名称，小写字母或数字开头，后面跟小写字母、数字、点、下划线或中划线（其中点、下划线、中划线不能直接连续），小写字母或数字结尾，3-64个字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 企业仓库实例描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 企业仓库实例规格，目前支持企业版(swr.ee.professional)
        /// </summary>
        [JsonProperty("spec", NullValueHandling = NullValueHandling.Ignore)]
        public SpecEnum Spec { get; set; }
        /// <summary>
        /// 用户虚拟私有云ID
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 用户子网的网络ID
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// vpc和子网所在项目编号
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 实例计费模式，目前只支持按需(postPaid)
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ChargeModeEnum ChargeMode { get; set; }
        /// <summary>
        /// 企业项目编号
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 指定资源tag.
        /// </summary>
        [JsonProperty("resource_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateInstanceRequestBodyResourceTags> ResourceTags { get; set; }

        /// <summary>
        /// obs桶是否开启加密, 如果开启了加密，则可以根据encrypt_type指定加密算法
        /// </summary>
        [JsonProperty("obs_encrypt", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ObsEncrypt { get; set; }

        /// <summary>
        /// obs桶加密类型，空值使用AES-256加密算法, gm为国密加密算法
        /// </summary>
        [JsonProperty("encrypt_type", NullValueHandling = NullValueHandling.Ignore)]
        public EncryptTypeEnum EncryptType { get; set; }
        /// <summary>
        /// 指定obs桶的名称，当指定自定义obs桶之后，则无需对obs_encrypt、encrypt_type进行传值。
        /// </summary>
        [JsonProperty("obs_bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsBucketName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateInstanceRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  spec: ").Append(Spec).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  resourceTags: ").Append(ResourceTags).Append("\n");
            sb.Append("  obsEncrypt: ").Append(ObsEncrypt).Append("\n");
            sb.Append("  encryptType: ").Append(EncryptType).Append("\n");
            sb.Append("  obsBucketName: ").Append(ObsBucketName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateInstanceRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateInstanceRequestBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Spec != input.Spec) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ChargeMode != input.ChargeMode) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.ResourceTags != input.ResourceTags || (this.ResourceTags != null && input.ResourceTags != null && !this.ResourceTags.SequenceEqual(input.ResourceTags))) return false;
            if (this.ObsEncrypt != input.ObsEncrypt || (this.ObsEncrypt != null && !this.ObsEncrypt.Equals(input.ObsEncrypt))) return false;
            if (this.EncryptType != input.EncryptType) return false;
            if (this.ObsBucketName != input.ObsBucketName || (this.ObsBucketName != null && !this.ObsBucketName.Equals(input.ObsBucketName))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Spec.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.ResourceTags != null) hashCode = hashCode * 59 + this.ResourceTags.GetHashCode();
                if (this.ObsEncrypt != null) hashCode = hashCode * 59 + this.ObsEncrypt.GetHashCode();
                hashCode = hashCode * 59 + this.EncryptType.GetHashCode();
                if (this.ObsBucketName != null) hashCode = hashCode * 59 + this.ObsBucketName.GetHashCode();
                return hashCode;
            }
        }
    }
}
