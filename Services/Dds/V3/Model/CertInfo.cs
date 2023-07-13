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
    /// 
    /// </summary>
    public class CertInfo 
    {
        /// <summary>
        /// 证书种类
        /// </summary>
        /// <value>证书种类</value>
        [JsonConverter(typeof(EnumClassConverter<CategoryEnum>))]
        public class CategoryEnum
        {
            /// <summary>
            /// Enum INTERNATIONAL for value: international
            /// </summary>
            public static readonly CategoryEnum INTERNATIONAL = new CategoryEnum("international");

            /// <summary>
            /// Enum NATIONAL for value: national
            /// </summary>
            public static readonly CategoryEnum NATIONAL = new CategoryEnum("national");

            private static readonly Dictionary<string, CategoryEnum> StaticFields =
            new Dictionary<string, CategoryEnum>()
            {
                { "international", INTERNATIONAL },
                { "national", NATIONAL },
            };

            private string _value;

            public CategoryEnum()
            {

            }

            public CategoryEnum(string value)
            {
                _value = value;
            }

            public static CategoryEnum FromValue(string value)
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

                if (this.Equals(obj as CategoryEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CategoryEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CategoryEnum a, CategoryEnum b)
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

            public static bool operator !=(CategoryEnum a, CategoryEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 证书种类
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public CategoryEnum Category { get; set; }
        /// <summary>
        /// 证书下载链接
        /// </summary>
        [JsonProperty("download_link", NullValueHandling = NullValueHandling.Ignore)]
        public string DownloadLink { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CertInfo {\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  downloadLink: ").Append(DownloadLink).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CertInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CertInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.DownloadLink == input.DownloadLink ||
                    (this.DownloadLink != null &&
                    this.DownloadLink.Equals(input.DownloadLink))
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
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.DownloadLink != null)
                    hashCode = hashCode * 59 + this.DownloadLink.GetHashCode();
                return hashCode;
            }
        }
    }
}
