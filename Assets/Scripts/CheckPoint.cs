﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{

    public int checkPoint;
    GameObject car;
    float ruler;

    void OnTriggerEnter(Collider other)
    {

        car = other.gameObject;
        if (car.tag == "Player")
        {

            //if(car.GetComponent<Lap>().points.Peek() == checkPoint) {

            //    car.GetComponent<Lap>().points.Pop();
            //    if(checkPoint == 1)
            //        car.GetComponent<Lap>().lap++;
            //}

            if (checkPoint == 4)
            {
                car.GetComponent<Lap>().point = 0;
                ruler = Vector3.Distance(car.GetComponent<Lap>().array[0].transform.position, car.GetComponent<Lap>().array[checkPoint].transform.position);
            }
            else
            {
                car.GetComponent<Lap>().point = checkPoint + 1;
                ruler = Vector3.Distance(car.GetComponent<Lap>().transform.position, car.GetComponent<Lap>().array[checkPoint + 1].transform.position);
            }
            car.GetComponent<Lap>().lastDis = (float)(Mathf.Round(ruler * 100000)) / 100000;
        }

        // if(checkPoint == 1) {
        //     //主要是看是不是到了最後一個判斷點 是增加圈數
        //     if(other.gameObject.GetComponent<Lap>().point == 2)
        //         other.gameObject.GetComponent<Lap>().lap += 1;
        //     //這邊主要是怕人會去逆向跑也會算進圈數中
        //     other.gameObject.GetComponent<Lap>().point = 1;
        //     other.gameObject.GetComponent<Lap>().lastPoint = 1;

        // }
        // else {
        //     //必須上一個判斷也要是和point一樣才可以把主要判斷點point變成目前的checkPoint
        //     if(other.gameObject.GetComponent<Lap>().point == checkPoint-1 && other.gameObject.GetComponent<Lap>().point == other.gameObject.GetComponent<Lap>().lastPoint)
        //         other.gameObject.GetComponent<Lap>().point = checkPoint;
        //     other.gameObject.GetComponent<Lap>().lastPoint = checkPoint;

        // }
    }
}
