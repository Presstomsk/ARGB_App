# ARGB_App
Приложение, позволяющее настраивать цвет в системе ARGB.

Приложение, позволяющее настраивать цвет в системе ARGB и добавлять его в список цветов. У приложения есть возможность просмотреть список всех добавленных цветов и удалить некоторые при необходимости.

При запуске приложения пользователю отображается главное окно, на котором располагаются ползунки для выбора значений компонент цвета, кнопка добавления цвета и список сохраненных цветов. Также есть элемент, визуализирующий выбранный цвет в реальном времени, т.е. при перетаскивании ползунка цвет обновляется.

![ARGB App interface](/Presstomsk/ARGB_App/blob/master/ARGB.jpg)

Пользователь может сделать любой из ползунков неактивным, сняв отметку с элемента управления CheckBox, расположенного слева от него.

При нажатии на кнопку Add выбранный цвет добавляется в список сохраненных цветов, для отображения которых используется элемент ScrollViewer.

Каждый сохраненный цвет может быть удален из списка цветов при помощи, соответствующей ему кнопки Delete.

При выборе пользователем цвета, который уже присутствует в списке цветов, кнопка Add должна становится
неактивной.
