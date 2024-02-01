using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TagEntity 
    {

        /// <summary>
        /// 标签键。  - 不能为空。  - 对于同一个实例，Key值唯一。  [- 长度不超过36个字符。](tag:cmcc,hk_tm,hws_eu,hws_ocb,ocb,tm)  [- 长度为1~128个字符（中文也可以输入128个字符）。](tag:hws,hws_hk,ctc,hk_sbc,sbc,dt,g42,hk_g42)  [- 不能包含“&#x3D;”，“*”，“&lt;”，“&gt;”，“\\”，“,”，“|”，“/”](tag:cmcc,hk_tm,hws_eu,hws_ocb,ocb,tm)  [- 由任意语种字母、数字、空格和字符组成，字符仅支持_ . : &#x3D; + - @](tag:hws,hws_hk,ctc,hk_sbc,sbc,dt,g42,hk_g42)  - 首尾字符不能为空格。
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// 标签值。  [- 不能为空。](tag:cmcc,hk_tm,hws_eu,hws_ocb,ocb,tm)  [- 长度不超过43个字符。](tag:cmcc,hk_tm,hws_eu,hws_ocb,ocb,tm)  [- 长度为0~255个字符（中文也可以输入255个字符）。](tag:hws,hws_hk,ctc,hk_sbc,sbc,dt,g42,hk_g42)  [- 不能包含“&#x3D;”，“*”，“&lt;”，“&gt;”，“\\”，“,”，“|”，“/”](tag:cmcc,hk_tm,hws_eu,hws_ocb,ocb,tm)  [- 由任意语种字母、数字、空格和字符组成，字符仅支持_ . : &#x3D; + - @](tag:hws,hws_hk,ctc,hk_sbc,sbc,dt,g42,hk_g42)  - 首尾字符不能为空格。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TagEntity {\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TagEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TagEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
