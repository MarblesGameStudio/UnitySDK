var JavascriptInterop =  {
  Purchase: function (productId) {
    try {
      window.dispatchReactUnityEvent("Purchase", productId);
    } catch (e) {
      console.error("Failed to dispatch Purchase.");
    }
  },
};

mergeInto(LibraryManager.library, JavascriptInterop);