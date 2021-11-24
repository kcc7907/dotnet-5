window.testing = async function (res, page) {
  console.log("test", res);
  console.log("page", page);
  if(!page)page = null
  if(!res)res = "tw"
  await i18next.use(i18nextHttpBackend).init(
    {
      lng: res,
      fallbackLng: "tw",
      ns: ["all","data",page],
      defaultNS: ["all","data",page],
      backend: {
        loadPath: "lang/{{lng}}/{{ns}}.json",
      },
    },
    function (err, t) {
      jqueryI18next.init(i18next, $);
      $("body").localize();
    }
  );

  async function langChange(lang) {
    //wait for the data loaded
    await i18next.changeLanguage(lang);
    //switch class on body
    $("body").localize().attr("class", `i18n-${lang}`);
  }

  //add event to change lang
  $("#btnEN").on("click", () => {
    langChange("en");
  });
  $("#btnTW").on("click", () => {
    langChange("tw");
  });
  $("#select").on("change", (e) => {
    langChange(e.target.value);
  });
};
