# ASP.NET MVC i18n 多語系

使用 Resource `資源檔` 實作中英日語系實作

## 環境
* Framework: .NET Framework 4.8
* 建議安裝 Visual Studio 擴充工具 [ResXManager](https://marketplace.visualstudio.com/items?itemName=TomEnglert.ResXManager)進行多語系`Resource`管理

## 資源檔 `Resource`
* 英文: Resource.resx
* 中文: Resource.zh-TW.resx
* 日文: Resource.ja-JP.resx

## 說明
* 預設語系為客戶端瀏覽器
* 客戶端選擇語系保存在`Request.Cookies["Lang"]`，期限設定1年
* 客戶端更換瀏覽器語，語系需重新選擇

## 參考文獻
* https://dotblogs.com.tw/wasichris/2015/06/20/151608
* https://blog.miniasp.com/post/2010/01/05/ASPNET-MVC-Developer-Note-Part-15-Globalization-and-Localization
* https://afana.me/archive/2011/01/14/aspnet-mvc-internationalization.aspx/