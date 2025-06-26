using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 镜像源信息。
    /// </summary>
    public class ImageRef 
    {
        /// <summary>
        /// 镜像源的镜像类型: * &#x60;gold&#x60; - 云市场镜像 * &#x60;public&#x60; - 公共镜像 * &#x60;private&#x60; - 私有镜像 * &#x60;shared&#x60; - 共享镜像 * &#x60;other&#x60; - 其他
        /// </summary>
        /// <value>镜像源的镜像类型: * &#x60;gold&#x60; - 云市场镜像 * &#x60;public&#x60; - 公共镜像 * &#x60;private&#x60; - 私有镜像 * &#x60;shared&#x60; - 共享镜像 * &#x60;other&#x60; - 其他</value>
        [JsonConverter(typeof(EnumClassConverter<ImageTypeEnum>))]
        public class ImageTypeEnum
        {
            /// <summary>
            /// Enum GOLD for value: gold
            /// </summary>
            public static readonly ImageTypeEnum GOLD = new ImageTypeEnum("gold");

            /// <summary>
            /// Enum PUBLIC for value: public
            /// </summary>
            public static readonly ImageTypeEnum PUBLIC = new ImageTypeEnum("public");

            /// <summary>
            /// Enum PRIVATE for value: private
            /// </summary>
            public static readonly ImageTypeEnum PRIVATE = new ImageTypeEnum("private");

            /// <summary>
            /// Enum SHARED for value: shared
            /// </summary>
            public static readonly ImageTypeEnum SHARED = new ImageTypeEnum("shared");

            /// <summary>
            /// Enum OTHER for value: other
            /// </summary>
            public static readonly ImageTypeEnum OTHER = new ImageTypeEnum("other");

            private static readonly Dictionary<string, ImageTypeEnum> StaticFields =
            new Dictionary<string, ImageTypeEnum>()
            {
                { "gold", GOLD },
                { "public", PUBLIC },
                { "private", PRIVATE },
                { "shared", SHARED },
                { "other", OTHER },
            };

            private string _value;

            public ImageTypeEnum()
            {

            }

            public ImageTypeEnum(string value)
            {
                _value = value;
            }

            public static ImageTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ImageTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ImageTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ImageTypeEnum a, ImageTypeEnum b)
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

            public static bool operator !=(ImageTypeEnum a, ImageTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 镜像源的唯一标识。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 镜像源的镜像类型: * &#x60;gold&#x60; - 云市场镜像 * &#x60;public&#x60; - 公共镜像 * &#x60;private&#x60; - 私有镜像 * &#x60;shared&#x60; - 共享镜像 * &#x60;other&#x60; - 其他
        /// </summary>
        [JsonProperty("image_type", NullValueHandling = NullValueHandling.Ignore)]
        public ImageTypeEnum ImageType { get; set; }
        /// <summary>
        /// 镜像源的规格编码，对于&#x60;gold&#x60;镜像类型，这个值是的必须项。
        /// </summary>
        [JsonProperty("spce_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpceCode { get; set; }

        /// <summary>
        /// 镜像源的产品ID，对于&#x60;gold&#x60;镜像类型，这个值是的必须项。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageRef {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  imageType: ").Append(ImageType).Append("\n");
            sb.Append("  spceCode: ").Append(SpceCode).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageRef);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageRef input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ImageType != input.ImageType) return false;
            if (this.SpceCode != input.SpceCode || (this.SpceCode != null && !this.SpceCode.Equals(input.SpceCode))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.ImageType.GetHashCode();
                if (this.SpceCode != null) hashCode = hashCode * 59 + this.SpceCode.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                return hashCode;
            }
        }
    }
}
