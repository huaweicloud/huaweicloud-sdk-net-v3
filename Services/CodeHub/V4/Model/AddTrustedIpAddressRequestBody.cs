using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// **参数解释：** 添加ip白名单请求体。
    /// </summary>
    public class AddTrustedIpAddressRequestBody 
    {
        /// <summary>
        /// **参数解释：** 格式类型。 - 0，表示指定ip。 - 1，表示ip范围。 - 2，表示CIDR。
        /// </summary>
        /// <value>**参数解释：** 格式类型。 - 0，表示指定ip。 - 1，表示ip范围。 - 2，表示CIDR。</value>
        [JsonConverter(typeof(EnumClassConverter<IpTypeEnum>))]
        public class IpTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly IpTypeEnum NUMBER_0 = new IpTypeEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly IpTypeEnum NUMBER_1 = new IpTypeEnum(1);

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            public static readonly IpTypeEnum NUMBER_2 = new IpTypeEnum(2);

            private static readonly Dictionary<int?, IpTypeEnum> StaticFields =
            new Dictionary<int?, IpTypeEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
                { 2, NUMBER_2 },
            };

            private int? _value;

            public IpTypeEnum()
            {

            }

            public IpTypeEnum(int? value)
            {
                _value = value;
            }

            public static IpTypeEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as IpTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IpTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IpTypeEnum a, IpTypeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(IpTypeEnum a, IpTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 是否允许访问代码仓库。 - 0，表示禁止访问。 - 1，表示允许访问。
        /// </summary>
        /// <value>**参数解释：** 是否允许访问代码仓库。 - 0，表示禁止访问。 - 1，表示允许访问。</value>
        [JsonConverter(typeof(EnumClassConverter<ViewFlagEnum>))]
        public class ViewFlagEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly ViewFlagEnum NUMBER_0 = new ViewFlagEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly ViewFlagEnum NUMBER_1 = new ViewFlagEnum(1);

            private static readonly Dictionary<int?, ViewFlagEnum> StaticFields =
            new Dictionary<int?, ViewFlagEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
            };

            private int? _value;

            public ViewFlagEnum()
            {

            }

            public ViewFlagEnum(int? value)
            {
                _value = value;
            }

            public static ViewFlagEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as ViewFlagEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ViewFlagEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ViewFlagEnum a, ViewFlagEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ViewFlagEnum a, ViewFlagEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 是否允许下载代码。 - 0，表示禁止下载。 - 1，表示允许下载。
        /// </summary>
        /// <value>**参数解释：** 是否允许下载代码。 - 0，表示禁止下载。 - 1，表示允许下载。</value>
        [JsonConverter(typeof(EnumClassConverter<DownloadFlagEnum>))]
        public class DownloadFlagEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly DownloadFlagEnum NUMBER_0 = new DownloadFlagEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly DownloadFlagEnum NUMBER_1 = new DownloadFlagEnum(1);

            private static readonly Dictionary<int?, DownloadFlagEnum> StaticFields =
            new Dictionary<int?, DownloadFlagEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
            };

            private int? _value;

            public DownloadFlagEnum()
            {

            }

            public DownloadFlagEnum(int? value)
            {
                _value = value;
            }

            public static DownloadFlagEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as DownloadFlagEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DownloadFlagEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DownloadFlagEnum a, DownloadFlagEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(DownloadFlagEnum a, DownloadFlagEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 是否允许提交代码。 - 0，表示禁止提交。 - 1，表示允许提交。
        /// </summary>
        /// <value>**参数解释：** 是否允许提交代码。 - 0，表示禁止提交。 - 1，表示允许提交。</value>
        [JsonConverter(typeof(EnumClassConverter<UploadFlagEnum>))]
        public class UploadFlagEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly UploadFlagEnum NUMBER_0 = new UploadFlagEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly UploadFlagEnum NUMBER_1 = new UploadFlagEnum(1);

            private static readonly Dictionary<int?, UploadFlagEnum> StaticFields =
            new Dictionary<int?, UploadFlagEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
            };

            private int? _value;

            public UploadFlagEnum()
            {

            }

            public UploadFlagEnum(int? value)
            {
                _value = value;
            }

            public static UploadFlagEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as UploadFlagEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(UploadFlagEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(UploadFlagEnum a, UploadFlagEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(UploadFlagEnum a, UploadFlagEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 格式类型。 - 0，表示指定ip。 - 1，表示ip范围。 - 2，表示CIDR。
        /// </summary>
        [JsonProperty("ip_type", NullValueHandling = NullValueHandling.Ignore)]
        public IpTypeEnum IpType { get; set; }
        /// <summary>
        /// **参数解释：** 起始ip。
        /// </summary>
        [JsonProperty("ip_start", NullValueHandling = NullValueHandling.Ignore)]
        public string IpStart { get; set; }

        /// <summary>
        /// **参数解释：** 结束ip。
        /// </summary>
        [JsonProperty("ip_end", NullValueHandling = NullValueHandling.Ignore)]
        public string IpEnd { get; set; }

        /// <summary>
        /// **参数解释：** 是否允许访问代码仓库。 - 0，表示禁止访问。 - 1，表示允许访问。
        /// </summary>
        [JsonProperty("view_flag", NullValueHandling = NullValueHandling.Ignore)]
        public ViewFlagEnum ViewFlag { get; set; }
        /// <summary>
        /// **参数解释：** 是否允许下载代码。 - 0，表示禁止下载。 - 1，表示允许下载。
        /// </summary>
        [JsonProperty("download_flag", NullValueHandling = NullValueHandling.Ignore)]
        public DownloadFlagEnum DownloadFlag { get; set; }
        /// <summary>
        /// **参数解释：** 是否允许提交代码。 - 0，表示禁止提交。 - 1，表示允许提交。
        /// </summary>
        [JsonProperty("upload_flag", NullValueHandling = NullValueHandling.Ignore)]
        public UploadFlagEnum UploadFlag { get; set; }
        /// <summary>
        /// **参数解释：** 备注。 **取值范围：** 字符串长度不少于0，不超过200。            
        /// </summary>
        [JsonProperty("remark", NullValueHandling = NullValueHandling.Ignore)]
        public string Remark { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddTrustedIpAddressRequestBody {\n");
            sb.Append("  ipType: ").Append(IpType).Append("\n");
            sb.Append("  ipStart: ").Append(IpStart).Append("\n");
            sb.Append("  ipEnd: ").Append(IpEnd).Append("\n");
            sb.Append("  viewFlag: ").Append(ViewFlag).Append("\n");
            sb.Append("  downloadFlag: ").Append(DownloadFlag).Append("\n");
            sb.Append("  uploadFlag: ").Append(UploadFlag).Append("\n");
            sb.Append("  remark: ").Append(Remark).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddTrustedIpAddressRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddTrustedIpAddressRequestBody input)
        {
            if (input == null) return false;
            if (this.IpType != input.IpType) return false;
            if (this.IpStart != input.IpStart || (this.IpStart != null && !this.IpStart.Equals(input.IpStart))) return false;
            if (this.IpEnd != input.IpEnd || (this.IpEnd != null && !this.IpEnd.Equals(input.IpEnd))) return false;
            if (this.ViewFlag != input.ViewFlag) return false;
            if (this.DownloadFlag != input.DownloadFlag) return false;
            if (this.UploadFlag != input.UploadFlag) return false;
            if (this.Remark != input.Remark || (this.Remark != null && !this.Remark.Equals(input.Remark))) return false;

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
                hashCode = hashCode * 59 + this.IpType.GetHashCode();
                if (this.IpStart != null) hashCode = hashCode * 59 + this.IpStart.GetHashCode();
                if (this.IpEnd != null) hashCode = hashCode * 59 + this.IpEnd.GetHashCode();
                hashCode = hashCode * 59 + this.ViewFlag.GetHashCode();
                hashCode = hashCode * 59 + this.DownloadFlag.GetHashCode();
                hashCode = hashCode * 59 + this.UploadFlag.GetHashCode();
                if (this.Remark != null) hashCode = hashCode * 59 + this.Remark.GetHashCode();
                return hashCode;
            }
        }
    }
}
