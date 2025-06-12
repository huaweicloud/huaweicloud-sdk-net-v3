using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 商品详细信息
    /// </summary>
    public class ProductDetailInfo 
    {
        /// <summary>
        /// 商品状态枚举 * ACTIVED：已激活 * UNACTIVED：未激活 * BLOCK: 被冻结，商品不可用 * DELETED：已删除
        /// </summary>
        /// <value>商品状态枚举 * ACTIVED：已激活 * UNACTIVED：未激活 * BLOCK: 被冻结，商品不可用 * DELETED：已删除</value>
        [JsonConverter(typeof(EnumClassConverter<StateEnum>))]
        public class StateEnum
        {
            /// <summary>
            /// Enum ACTIVED for value: ACTIVED
            /// </summary>
            public static readonly StateEnum ACTIVED = new StateEnum("ACTIVED");

            /// <summary>
            /// Enum UNACTIVED for value: UNACTIVED
            /// </summary>
            public static readonly StateEnum UNACTIVED = new StateEnum("UNACTIVED");

            /// <summary>
            /// Enum BLOCK for value: BLOCK
            /// </summary>
            public static readonly StateEnum BLOCK = new StateEnum("BLOCK");

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            public static readonly StateEnum DELETED = new StateEnum("DELETED");

            private static readonly Dictionary<string, StateEnum> StaticFields =
            new Dictionary<string, StateEnum>()
            {
                { "ACTIVED", ACTIVED },
                { "UNACTIVED", UNACTIVED },
                { "BLOCK", BLOCK },
                { "DELETED", DELETED },
            };

            private string _value;

            public StateEnum()
            {

            }

            public StateEnum(string value)
            {
                _value = value;
            }

            public static StateEnum FromValue(string value)
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

                if (this.Equals(obj as StateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StateEnum a, StateEnum b)
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

            public static bool operator !=(StateEnum a, StateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 标签。单个标签16字节，多个用逗号分隔，最多50个。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cover", NullValueHandling = NullValueHandling.Ignore)]
        public ProductCoverDetailInfo Cover { get; set; }

        /// <summary>
        /// 文本列表
        /// </summary>
        [JsonProperty("text_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProductTextInfo> TextList { get; set; }

        /// <summary>
        /// 资产列表,仅支持图片、视频、音频资产
        /// </summary>
        [JsonProperty("asset_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProductMediaDetailInfo> AssetList { get; set; }

        /// <summary>
        /// 商品创建时间，格式遵循：RFC 3339。 例 “2020-07-30T10:43:17Z”。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 商品更新时间，格式遵循：RFC 3339。 例 “2020-07-30T10:43:17Z”。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 商品状态枚举 * ACTIVED：已激活 * UNACTIVED：未激活 * BLOCK: 被冻结，商品不可用 * DELETED：已删除
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateEnum State { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductDetailInfo {\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  cover: ").Append(Cover).Append("\n");
            sb.Append("  textList: ").Append(TextList).Append("\n");
            sb.Append("  assetList: ").Append(AssetList).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProductDetailInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProductDetailInfo input)
        {
            if (input == null) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.Cover != input.Cover || (this.Cover != null && !this.Cover.Equals(input.Cover))) return false;
            if (this.TextList != input.TextList || (this.TextList != null && input.TextList != null && !this.TextList.SequenceEqual(input.TextList))) return false;
            if (this.AssetList != input.AssetList || (this.AssetList != null && input.AssetList != null && !this.AssetList.SequenceEqual(input.AssetList))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.State != input.State) return false;

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
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Cover != null) hashCode = hashCode * 59 + this.Cover.GetHashCode();
                if (this.TextList != null) hashCode = hashCode * 59 + this.TextList.GetHashCode();
                if (this.AssetList != null) hashCode = hashCode * 59 + this.AssetList.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                return hashCode;
            }
        }
    }
}
