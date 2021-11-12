class UIPanelHUD {
    setupMono(mono) {
        console.log("passed mono : " + mono);
        this.mono = mono;
        mono.onAwake = () => {
            console.log(mono + " onAwake")
        }


        mono.onStart = () => {
            console.log(mono + " onStart")
        }


        mono.onDestroy = () => {
            console.log(mono + " onDestroy")
        }
    }

    close() {
        this.mono.Close();
    }
}

let uiPanelHUD = null;

function getJsUI(uiName) {
    switch (uiName) {
        case "UIPanelHUD":
            if (uiPanelHUD === null) {
                uiPanelHUD = new UIPanelHUD();
            }
            return uiPanelHUD.setupMono;
    }

    return null;
}

function closJsUI(uiName) {

    switch (uiName) {
        case "UIPanelHUD":
            uiPanelHUD.close();
            uiPanelHUD = null;
            break;

    }
}

module.exports = getJsUI;