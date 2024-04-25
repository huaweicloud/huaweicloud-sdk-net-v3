using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ocr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SmartDocumentRecognizerLayoutBlock 
    {

        /// <summary>
        /// 文字块的区域位置信息，列表形式，包含文字区域四个顶点的二维坐标（x,y）;坐标原点为图片左上角，x轴沿水平方向，y轴沿竖直方向。 
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<int?>> Location { get; set; }

        /// <summary>
        /// 文档区域类别，包含text、title、sub_title、image、image_caption、form、table、table_caption、header、footer、page_number、reference、formula、stamp、directory共15个类别。     
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 文档区域文字内容。对于表格与图像，不返回其中的文字内容。 
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// 文字识别结果索引列表，表示ocr_result的words_block_list中哪些文本框位于该文档区域内。 
        /// </summary>
        [JsonProperty("words_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> WordsIds { get; set; }

        /// <summary>
        /// 仅当type为\&quot;table\&quot;且入参table为True时返回该字段，表示当前逻辑表格区域对应table_result中哪一项识别结果。 
        /// </summary>
        [JsonProperty("table_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TableId { get; set; }

        /// <summary>
        /// 仅当type为\&quot;form\&quot;且入参form为True时返回该字段，表示当前有线表单区域对应form_result中哪一项识别结果。 
        /// </summary>
        [JsonProperty("form_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? FormId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartDocumentRecognizerLayoutBlock {\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  text: ").Append(Text).Append("\n");
            sb.Append("  wordsIds: ").Append(WordsIds).Append("\n");
            sb.Append("  tableId: ").Append(TableId).Append("\n");
            sb.Append("  formId: ").Append(FormId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmartDocumentRecognizerLayoutBlock);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartDocumentRecognizerLayoutBlock input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Location == input.Location ||
                    this.Location != null &&
                    input.Location != null &&
                    this.Location.SequenceEqual(input.Location)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.WordsIds == input.WordsIds ||
                    this.WordsIds != null &&
                    input.WordsIds != null &&
                    this.WordsIds.SequenceEqual(input.WordsIds)
                ) && 
                (
                    this.TableId == input.TableId ||
                    (this.TableId != null &&
                    this.TableId.Equals(input.TableId))
                ) && 
                (
                    this.FormId == input.FormId ||
                    (this.FormId != null &&
                    this.FormId.Equals(input.FormId))
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
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.WordsIds != null)
                    hashCode = hashCode * 59 + this.WordsIds.GetHashCode();
                if (this.TableId != null)
                    hashCode = hashCode * 59 + this.TableId.GetHashCode();
                if (this.FormId != null)
                    hashCode = hashCode * 59 + this.FormId.GetHashCode();
                return hashCode;
            }
        }
    }
}
