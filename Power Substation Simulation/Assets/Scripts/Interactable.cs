﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;

public interface Interactable
{
    void interact(GameObject interactor);
    void displayInteractionMessage(GameObject interactor);
}