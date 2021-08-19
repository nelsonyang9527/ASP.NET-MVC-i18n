using System.ComponentModel;

namespace GlobalResources
{
    /// <summary>
    /// 語系清單
    /// </summary>
    public enum Language
    {
        /// <summary>
        /// 英文
        /// </summary>
        [Description("en-US")]
        English = 1,

        /// <summary>
        /// 繁體中文
        /// </summary>
        [Description("zh-TW")]
        TraditionalChinese = 2,

        /// <summary>
        /// 日文
        /// </summary>
        [Description("ja-JP")]
        Japanese = 3
    }
}
