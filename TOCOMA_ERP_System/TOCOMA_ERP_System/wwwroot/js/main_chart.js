const ctx = document.getElementById("myChart");
const ctx2 = document.getElementById("myChart2");
/*const FirstmyChart = document.querySelector("#myChart");*/
/*const ctx = FirstmyChart.getContext("2d")*/
const SecoundmyChart2 = document.getElementById("myChart2");
/*const ctx2 = SecoundmyChart2.getContext("2d")*/
//const ctx2 = document.getElementById("myChart2").getContext("2d");
const DATA_COUNT = 12;
const labels = [];
for (let i = 0; i < DATA_COUNT; ++i) {
  labels.push(i.toString());
}
const datapoints = [0, 20, 20, 60, 60, 120, NaN, 180, 120, 125, 105, 110, 170];
const data = {
  labels: labels,
  datasets: [
    {
      label: "Cubic interpolation (monotone)",
      data: datapoints,
      borderColor: "#EC7063",
      fill: false,
      cubicInterpolationMode: "monotone",
      tension: 0.4,
    },
    {
      label: "Cubic interpolation",
      data: datapoints,
      borderColor: "#5DADE2",
      fill: false,
      tension: 0.4,
    },
    {
      label: "Linear interpolation (default)",
      data: datapoints,
      borderColor: "#5DADE2",
      fill: false,
    },
  ],
};

const config = {
  type: "line",
  data: data,
  options: {
    responsive: true,
    plugins: {
      title: {
        display: true,
        text: "Chart.js Line Chart - Cubic interpolation mode",
      },
    },
    interaction: {
      intersect: false,
    },
    scales: {
      x: {
        display: true,
        title: {
          display: true,
        },
      },
      y: {
        display: true,
        title: {
          display: true,
        },
        suggestedMin: -10,
        suggestedMax: 200,
      },
    },
  },
};

const myChart = new Chart(ctx, config);

const labels2 = ["January", "February", "March", "April", "May", "June"];

const data2 = {
  labels: labels,
  datasets: [
    {
      label: "My First dataset",
      backgroundColor: "rgb(255, 99, 132)",
      borderColor: "rgb(255, 99, 132)",
      data: [0, 10, 5, 2, 20, 30, 45],
    },
  ],
};

const config2 = {
  type: "line",
  data: data2,
  options: {
    responsive: true,
    plugins: {
      title: {
        display: true,
        text: "Chart.js Line Chart - Cubic interpolation mode",
      },
    },
  },
};
const myChart2 = new Chart(ctx2, config2);
