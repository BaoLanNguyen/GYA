using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossClear : MonoBehaviour
{ public GameClearManager clearManager;
    // Start is called before the first frame update
    private void OnDestroy() {
        clearManager.gameClear();
    }
}
