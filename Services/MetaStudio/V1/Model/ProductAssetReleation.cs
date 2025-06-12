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
    /// 更新资产组合
    /// </summary>
    public class ProductAssetReleation 
    {
        /// <summary>
        /// 添加或删除资产关联 - LINK ：将资产纳入管理 - UNLINK ：将资产移除管理
        /// </summary>
        /// <value>添加或删除资产关联 - LINK ：将资产纳入管理 - UNLINK ：将资产移除管理</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum LINK for value: LINK
            /// </summary>
            public static readonly ActionEnum LINK = new ActionEnum("LINK");

            /// <summary>
            /// Enum UNLINK for value: UNLINK
            /// </summary>
            public static readonly ActionEnum UNLINK = new ActionEnum("UNLINK");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "LINK", LINK },
                { "UNLINK", UNLINK },
            };

            private string _value;

            public ActionEnum()
            {

            }

            public ActionEnum(string value)
            {
                _value = value;
            }

            public static ActionEnum FromValue(string value)
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

                if (this.Equals(obj as ActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ActionEnum a, ActionEnum b)
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

            public static bool operator !=(ActionEnum a, ActionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("asset_item", NullValueHandling = NullValueHandling.Ignore)]
        public ProductMediaInfo AssetItem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("text_item", NullValueHandling = NullValueHandling.Ignore)]
        public ProductTextInfo TextItem { get; set; }

        /// <summary>
        /// 添加或删除资产关联 - LINK ：将资产纳入管理 - UNLINK ：将资产移除管理
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductAssetReleation {\n");
            sb.Append("  assetItem: ").Append(AssetItem).Append("\n");
            sb.Append("  textItem: ").Append(TextItem).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProductAssetReleation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProductAssetReleation input)
        {
            if (input == null) return false;
            if (this.AssetItem != input.AssetItem || (this.AssetItem != null && !this.AssetItem.Equals(input.AssetItem))) return false;
            if (this.TextItem != input.TextItem || (this.TextItem != null && !this.TextItem.Equals(input.TextItem))) return false;
            if (this.Action != input.Action) return false;

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
                if (this.AssetItem != null) hashCode = hashCode * 59 + this.AssetItem.GetHashCode();
                if (this.TextItem != null) hashCode = hashCode * 59 + this.TextItem.GetHashCode();
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                return hashCode;
            }
        }
    }
}
