using System.Threading;

namespace GlobalResources
{
    /// <summary>
    /// 語系相關
    /// </summary>
    public static class CultureHelper
    {
        /// <summary>
        /// 取得合法語系名稱
        /// </summary>
        /// <param name="name">語系名稱 (e.g. en-US)</param>
        public static string GetImplementedCulture(string name)
        {
            // give a default culture just in case
            string cultureName = GetDefaultCulture();

            // check if it's implemented
            if (EnumHelper.TryGetValueFromDescription<Language>(name))
                cultureName = name;

            return cultureName;
        }

        /// <summary>
        /// 取得預設 語系名稱
        /// </summary>
        /// <returns></returns>
        public static string GetDefaultCulture()
        {
            return Language.English.GetDescription();
        }

        /// <summary>
        /// 取得目前 語系
        /// </summary>
        /// <returns></returns>
        public static Language GetCurrentLanguage()
        {
            var currentCulture = Thread.CurrentThread.CurrentCulture.Name;

            // get implemented culture name
            currentCulture = GetImplementedCulture(currentCulture);

            // get language by implemented culture name
            return EnumHelper.GetValueFromDescription<Language>(currentCulture);
        }
    }
}
