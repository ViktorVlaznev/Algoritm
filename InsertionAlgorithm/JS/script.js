// Сортировка методом вставки

/// <summary>
/// Функция сортировки методом вставки
/// </summary>
/// <param name="array">первоначальный массив</param>
/// <returns>отсортированный массив</returns>
function InsertionSortingAlgorithm(array) {
    for (let i = 1; i < array.length; i++) {
        let current = array[i];
        let j = i - 1;
        while (j >= 0 && array[j] > current) {
            array[j + 1] = array[j];
            j--;
        }
        array[j + 1] = current;
    }
    return array;
}

let arr = [31, 41, 59, 26, 41, 58];

console.log(arr);
console.log(InsertionSortingAlgorithm(arr));