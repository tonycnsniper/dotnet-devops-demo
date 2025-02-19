import "./App.css";
import Layout from "./components/Layout";
import MoveList from "./pages/movies/List";

function App() {
  return (
    <div className="App">
      <Layout>
        <MoveList />
      </Layout>
    </div>
  );
}

export default App;
