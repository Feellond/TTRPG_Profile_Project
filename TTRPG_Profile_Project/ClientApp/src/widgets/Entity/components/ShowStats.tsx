import {
  InputNumber,
  InputNumberValueChangeEvent,
} from "primereact/inputnumber";
import React, { useEffect, useState } from "react";
import {
  Control,
  Controller,
  FieldValues,
  UseFormGetValues,
} from "react-hook-form";
import { ICreature, IStatsList } from "shared/models";

interface IShowStats {
  statList: IStatsList | null;
  setStatList: React.Dispatch<React.SetStateAction<IStatsList>>;
  data: ICreature | null;
  control: Control<FieldValues, any>;
  getValues: UseFormGetValues<FieldValues>;
  isEditMode: boolean;
}

export const ShowStats = ({
  statList,
  setStatList,
  data,
  isEditMode,
  control,
  getValues,
}: IShowStats) => {
  //const [stats, setStats] = useState<IStatsList>(null);

  // const LoadStats = () => {
  //   let getStats: IStatsList = getValues("statsList");
  //   setStats(getStats);

  //   setStatList(getStats);
  // }

  const handleIntellectChange = (value: number) => {
    const updatedStats = { ...statList, intellectValue: value };
    setStatList(updatedStats); // Обновить statList
  };

  useEffect(() => {
    //LoadStats();
  }, [isEditMode, data, statList]);

  return (
    <div className="flex mr-6 statsTable">
      <div className="m-2 text-center">
        <table className="statList">
          <tbody>
            <tr>
              <th scope="row">Инт</th>
              <td>
                {isEditMode ? (
                  <Controller
                    name="statsList.intellectValue"
                    control={control}
                    render={({ field }) => (
                      <>
                        <InputNumber
                          id={field.name}
                          value={field.value}
                          onValueChange={(e: InputNumberValueChangeEvent) => {
                            field.onChange(e.value);
                            const updatedStats = { ...statList, intellectValue: e.value };
                            setStatList(updatedStats); // Обновить statList
                            //handleIntellectChange(e.value)
                          }}
                          minFractionDigits={0}
                          maxFractionDigits={0}
                          min={0}
                          max={9999}
                        />
                      </>
                    )}
                  />
                ) : (
                  <div>{statList?.intellectValue}</div>
                )}
              </td>
            </tr>
            <tr>
              <th scope="row">Реа</th>
              <td>
                {isEditMode ? (
                  <Controller
                    name="statsList.reactionValue"
                    control={control}
                    render={({ field }) => (
                      <>
                        <InputNumber
                          id={field.name}
                          value={field.value}
                          onValueChange={(e: InputNumberValueChangeEvent) => {
                            field.onChange(e.value);
                            const updatedStats = { ...statList, reactionValue: e.value };
                            setStatList(updatedStats); // Обновить statList
                          }}
                          minFractionDigits={0}
                          maxFractionDigits={0}
                          min={0}
                          max={9999}
                        />
                      </>
                    )}
                  />
                ) : (
                  <div>{statList?.reactionValue}</div>
                )}
              </td>
            </tr>
            <tr>
              <th scope="row">Лвк</th>
              <td>
                {isEditMode ? (
                  <Controller
                    name="statsList.dexterityValue"
                    control={control}
                    render={({ field }) => (
                      <>
                        <InputNumber
                          id={field.name}
                          value={field.value}
                          onValueChange={(e: InputNumberValueChangeEvent) => {
                            field.onChange(e.value);
                            const updatedStats = { ...statList, dexterityValue: e.value };
                            setStatList(updatedStats); // Обновить statList
                          }}
                          minFractionDigits={0}
                          maxFractionDigits={0}
                          min={0}
                          max={9999}
                        />
                      </>
                    )}
                  />
                ) : (
                  <div>{statList?.dexterityValue}</div>
                )}
              </td>
            </tr>
            <tr>
              <th scope="row">Тел</th>
              <td>
                {isEditMode ? (
                  <Controller
                    name="statsList.constitutionValue"
                    control={control}
                    render={({ field }) => (
                      <>
                        <InputNumber
                          id={field.name}
                          value={field.value}
                          onValueChange={(e: InputNumberValueChangeEvent) => {
                            field.onChange(e.value);
                            const updatedStats = { ...statList, constitutionValue: e.value };
                            setStatList(updatedStats); // Обновить statList
                          }}
                          minFractionDigits={0}
                          maxFractionDigits={0}
                          min={0}
                          max={9999}
                        />
                      </>
                    )}
                  />
                ) : (
                  <div>{statList?.constitutionValue}</div>
                )}
              </td>
            </tr>
            <tr>
              <th scope="row">Скор</th>
              <td>
                {isEditMode ? (
                  <Controller
                    name="statsList.speedValue"
                    control={control}
                    render={({ field }) => (
                      <>
                        <InputNumber
                          id={field.name}
                          value={field.value}
                          onValueChange={(e: InputNumberValueChangeEvent) => {
                            field.onChange(e.value);
                            const updatedStats = { ...statList, speedValue: e.value };
                            setStatList(updatedStats); // Обновить statList
                          }}
                          minFractionDigits={0}
                          maxFractionDigits={0}
                          min={0}
                          max={9999}
                        />
                      </>
                    )}
                  />
                ) : (
                  <div>{statList?.speedValue}</div>
                )}
              </td>
            </tr>
            <tr>
              <th scope="row">Эмп</th>
              <td>
                {isEditMode ? (
                  <Controller
                    name="statsList.empathyValue"
                    control={control}
                    render={({ field }) => (
                      <>
                        <InputNumber
                          id={field.name}
                          value={field.value}
                          onValueChange={(e: InputNumberValueChangeEvent) => {
                            field.onChange(e.value);
                            const updatedStats = { ...statList, empathyValue: e.value };
                            setStatList(updatedStats); // Обновить statList
                          }}
                          minFractionDigits={0}
                          maxFractionDigits={0}
                          min={0}
                          max={9999}
                        />
                      </>
                    )}
                  />
                ) : (
                  <div>{statList?.empathyValue}</div>
                )}
              </td>
            </tr>
            <tr>
              <th scope="row">Рем</th>
              <td>
                {isEditMode ? (
                  <Controller
                    name="statsList.craftsmanshipValue"
                    control={control}
                    render={({ field }) => (
                      <>
                        <InputNumber
                          id={field.name}
                          value={field.value}
                          onValueChange={(e: InputNumberValueChangeEvent) => {
                            field.onChange(e.value);
                            const updatedStats = { ...statList, craftsmanshipValue: e.value };
                            setStatList(updatedStats); // Обновить statList
                          }}
                          minFractionDigits={0}
                          maxFractionDigits={0}
                          min={0}
                          max={9999}
                        />
                      </>
                    )}
                  />
                ) : (
                  <div>{statList?.craftsmanshipValue}</div>
                )}
              </td>
            </tr>
            <tr>
              <th scope="row">Воля</th>
              <td>
                {isEditMode ? (
                  <Controller
                    name="statsList.willpowerValue"
                    control={control}
                    render={({ field }) => (
                      <>
                        <InputNumber
                          id={field.name}
                          value={field.value}
                          onValueChange={(e: InputNumberValueChangeEvent) => {
                            field.onChange(e.value);
                            const updatedStats = { ...statList, willpowerValue: e.value };
                            setStatList(updatedStats); // Обновить statList
                          }}
                          minFractionDigits={0}
                          maxFractionDigits={0}
                          min={0}
                          max={9999}
                        />
                      </>
                    )}
                  />
                ) : (
                  <div>{statList?.willpowerValue}</div>
                )}
              </td>
            </tr>
            <tr>
              <th scope="row">Удач</th>
              <td>
                {isEditMode ? (
                  <Controller
                    name="statsList.luckValue"
                    control={control}
                    render={({ field }) => (
                      <>
                        <InputNumber
                          id={field.name}
                          value={field.value}
                          onValueChange={(e: InputNumberValueChangeEvent) => {
                            field.onChange(e.value);
                            const updatedStats = { ...statList, luckValue: e.value };
                            setStatList(updatedStats); // Обновить statList
                          }}
                          minFractionDigits={0}
                          maxFractionDigits={0}
                          min={0}
                          max={9999}
                        />
                      </>
                    )}
                  />
                ) : (
                  <div>{statList?.luckValue}</div>
                )}
              </td>
            </tr>
          </tbody>
        </table>
      </div>

      <div className="m-2 text-center">
        <table className="statList">
          <tbody>
            <tr>
              <th scope="row">Уст</th>
              <td>
                {isEditMode ? (
                  <Controller
                    name="statsList.resilienceValue"
                    control={control}
                    render={({ field }) => (
                      <>
                        <InputNumber
                          id={field.name}
                          value={field.value}
                          onValueChange={(e: InputNumberValueChangeEvent) => {
                            field.onChange(e.value);
                            const updatedStats = { ...statList, resilienceValue: e.value };
                            setStatList(updatedStats); // Обновить statList
                          }}
                          minFractionDigits={0}
                          maxFractionDigits={0}
                          min={0}
                          max={9999}
                        />
                      </>
                    )}
                  />
                ) : (
                  <div>{statList?.resilienceValue}</div>
                )}
              </td>
            </tr>
            <tr>
              <th scope="row">Бег</th>
              <td>
                {isEditMode ? (
                  <Controller
                    name="statsList.runningValue"
                    control={control}
                    render={({ field }) => (
                      <>
                        <InputNumber
                          id={field.name}
                          value={field.value}
                          onValueChange={(e: InputNumberValueChangeEvent) => {
                            field.onChange(e.value);
                            const updatedStats = { ...statList, runningValue: e.value };
                            setStatList(updatedStats); // Обновить statList
                          }}
                          minFractionDigits={0}
                          maxFractionDigits={0}
                          min={0}
                          max={9999}
                        />
                      </>
                    )}
                  />
                ) : (
                  <div>{statList?.runningValue}</div>
                )}
              </td>
            </tr>
            <tr>
              <th scope="row">Прж</th>
              <td>
                {isEditMode ? (
                  <Controller
                    name="statsList.jumpingValue"
                    control={control}
                    render={({ field }) => (
                      <>
                        <InputNumber
                          id={field.name}
                          value={field.value}
                          onValueChange={(e: InputNumberValueChangeEvent) => {
                            field.onChange(e.value);
                            const updatedStats = { ...statList, jumpingValue: e.value };
                            setStatList(updatedStats); // Обновить statList
                          }}
                          minFractionDigits={0}
                          maxFractionDigits={0}
                          min={0}
                          max={9999}
                        />
                      </>
                    )}
                  />
                ) : (
                  <div>{statList?.jumpingValue}</div>
                )}
              </td>
            </tr>
            <tr>
              <th scope="row">Вын</th>
              <td>
                {isEditMode ? (
                  <Controller
                    name="statsList.enduranceValue"
                    control={control}
                    render={({ field }) => (
                      <>
                        <InputNumber
                          id={field.name}
                          value={field.value}
                          onValueChange={(e: InputNumberValueChangeEvent) => {
                            field.onChange(e.value);
                            const updatedStats = { ...statList, enduranceValue: e.value };
                            setStatList(updatedStats); // Обновить statList
                          }}
                          minFractionDigits={0}
                          maxFractionDigits={0}
                          min={0}
                          max={9999}
                        />
                      </>
                    )}
                  />
                ) : (
                  <div>{statList?.enduranceValue}</div>
                )}
              </td>
            </tr>
            <tr>
              <th scope="row">Вес</th>
              <td>
                {isEditMode ? (
                  <Controller
                    name="statsList.weightValue"
                    control={control}
                    render={({ field }) => (
                      <>
                        <InputNumber
                          id={field.name}
                          value={field.value}
                          onValueChange={(e: InputNumberValueChangeEvent) => {
                            field.onChange(e.value);
                            const updatedStats = { ...statList, weightValue: e.value };
                            setStatList(updatedStats); // Обновить statList
                          }}
                          minFractionDigits={0}
                          maxFractionDigits={0}
                          min={0}
                          max={9999}
                        />
                      </>
                    )}
                  />
                ) : (
                  <div>{statList?.weightValue}</div>
                )}
              </td>
            </tr>
            <tr>
              <th scope="row">Отд</th>
              <td>
                {isEditMode ? (
                  <Controller
                    name="statsList.restValue"
                    control={control}
                    render={({ field }) => (
                      <>
                        <InputNumber
                          id={field.name}
                          value={field.value}
                          onValueChange={(e: InputNumberValueChangeEvent) => {
                            field.onChange(e.value);
                            const updatedStats = { ...statList, restValue: e.value };
                            setStatList(updatedStats); // Обновить statList
                          }}
                          minFractionDigits={0}
                          maxFractionDigits={0}
                          min={0}
                          max={9999}
                        />
                      </>
                    )}
                  />
                ) : (
                  <div>{statList?.restValue}</div>
                )}
              </td>
            </tr>
            <tr>
              <th scope="row">Пз</th>
              <td>
                {isEditMode ? (
                  <Controller
                    name="statsList.healthPointsValue"
                    control={control}
                    render={({ field }) => (
                      <>
                        <InputNumber
                          id={field.name}
                          value={field.value}
                          onValueChange={(e: InputNumberValueChangeEvent) => {
                            field.onChange(e.value);
                            const updatedStats = { ...statList, healthPointsValue: e.value };
                            setStatList(updatedStats); // Обновить statList
                          }}
                          minFractionDigits={0}
                          maxFractionDigits={0}
                          min={0}
                          max={9999}
                        />
                      </>
                    )}
                  />
                ) : (
                  <div>{statList?.healthPointsValue}</div>
                )}
              </td>
            </tr>
            <tr>
              <th scope="row">Энер</th>
              <td>
                {isEditMode ? (
                  <Controller
                    name="statsList.energyValue"
                    control={control}
                    render={({ field }) => (
                      <>
                        <InputNumber
                          id={field.name}
                          value={field.value}
                          onValueChange={(e: InputNumberValueChangeEvent) => {
                            field.onChange(e.value);
                            const updatedStats = { ...statList, energyValue: e.value };
                            setStatList(updatedStats); // Обновить statList
                          }}
                          minFractionDigits={0}
                          maxFractionDigits={0}
                          min={0}
                          max={9999}
                        />
                      </>
                    )}
                  />
                ) : (
                  <div>{statList?.energyValue}</div>
                )}
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>
  );
};
