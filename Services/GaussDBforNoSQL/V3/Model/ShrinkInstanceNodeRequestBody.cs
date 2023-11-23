using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ShrinkInstanceNodeRequestBody 
    {

        /// <summary>
        /// 随机缩减的节点数量。 - GeminiDB Cassandra实例该字段取值为1~10。 - GeminiDB Redis该字段取值为1。 说明： 如果客户端采用直连节点方式，不推荐使用随机节点缩容。
        /// </summary>
        [JsonProperty("num", NullValueHandling = NullValueHandling.Ignore)]
        public int? Num { get; set; }

        /// <summary>
        /// 指定缩容节点的ID，且该节点必须支持节点缩容。如果该字段不传指定缩减的节点ID，将根据系统内部策略缩减指定个数的节点。说明： - num与node_list必须有一个字段传值。   - 如果node_list传值时，GeminiDB Cassandra长度必须为1~10，GeminiDB Redis 长度必须为1。   - 如果num与node_list同时传值时，则以node_list的值为主。 - 如果node_list取值为空时，缩容以随机节点缩容进行；node_list字段取值不为空，缩容以指定节点ID进行。 - 节点缩容前，请避免直连节点，以防该节点缩容导致业务中断。
        /// </summary>
        [JsonProperty("node_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NodeList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShrinkInstanceNodeRequestBody {\n");
            sb.Append("  num: ").Append(Num).Append("\n");
            sb.Append("  nodeList: ").Append(NodeList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShrinkInstanceNodeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShrinkInstanceNodeRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Num == input.Num ||
                    (this.Num != null &&
                    this.Num.Equals(input.Num))
                ) && 
                (
                    this.NodeList == input.NodeList ||
                    this.NodeList != null &&
                    input.NodeList != null &&
                    this.NodeList.SequenceEqual(input.NodeList)
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
                if (this.Num != null)
                    hashCode = hashCode * 59 + this.Num.GetHashCode();
                if (this.NodeList != null)
                    hashCode = hashCode * 59 + this.NodeList.GetHashCode();
                return hashCode;
            }
        }
    }
}
