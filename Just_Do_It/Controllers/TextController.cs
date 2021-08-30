using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;
using Unity;
using UnityEngine;
using BeatSaberMarkupLanguage;
using System.Reflection;
using BeatSaberMarkupLanguage.Attributes;
using TMPro;
using HMUI;

namespace Just_Do_It.Controllers
{
    class TextController : IInitializable, IDisposable
    {
        private ResultsViewController _resultsViewController { get; set; }


        public TextController(ResultsViewController rvc)
        {
            this._resultsViewController = rvc;
        }
        public void Initialize()
        {
            _resultsViewController.didActivateEvent += OnActivate;
        }
        public void Dispose()
        {
            _resultsViewController.didActivateEvent -= OnActivate;
        }

        private void OnActivate(bool _, bool __, bool ___)
        {
            var faildBanner = _resultsViewController.transform.FindChild("Container").FindChild("FailedBanner");
            if(!faildBanner) { return; }
            try
            {
                var textMesh = faildBanner.FindChild("InfoText").GetComponent<CurvedTextMeshPro>();

                textMesh.text = Quotes.GetQuote();
                textMesh.color = new Color(255f, 255f, 255f);

                var bg = faildBanner.FindChild("BG").GetComponent<ImageView>();
                bg.color = new Color(0f, 0f, 0f,1f);
                bg.color1 = new Color(255f, 1f, 0f, 0.5434783f);
                bg.color0 = new Color(2.591506E-09f, 0f, 0f, 1f);

            }
            catch (Exception e)
            {
                Plugin.Log.Error("Error changing level failed text :(    :");
                Plugin.Log.Error(e);
            }
        }
    }
}
