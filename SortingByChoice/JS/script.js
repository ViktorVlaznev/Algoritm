// Сортировка методом выбора

/// <summary>
/// Функция сортировки методом выбора
/// </summary>
/// <param name="array">первоначальный массив</param>
/// <returns>отсортированный массив</returns>
function SortingByChoice(array) {
    let result = [];
    let size = array.length;
    for (let i = 0; i < size; i++) {
        result[i] = array[array.indexOf(Math.min(...array))];
        arr.splice(arr.indexOf(Math.min(...arr)), 1);
    }
    return result;
}

let arr = [31, 41, 59, 26, 41, 58];
console.log(arr);
console.log(arr.sort());
console.log(SortingByChoice(arr));
